using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class loginAndRegister : MonoBehaviour
{
    public string StartScene;
    public GameObject canvas;

    public InputField IdLogInput;
    public InputField PassLogInput;

    public InputField IdRegInput;
    public InputField PassRegInput;
    public InputField PassConfInput;

    public GameObject ErrorText;
    public GameObject ErrorPassText;
    public GameObject ErrorFieldsText;
    public GameObject ErrorExistingUsernameText;


    public void Start()
    {
        ErrorPassText.SetActive(false);
        ErrorText.SetActive(false);
        ErrorFieldsText.SetActive(false);
        ErrorExistingUsernameText.SetActive(false);

    }

    public void loginMethod()
    {
        if (PassLogInput.text == "" || IdLogInput.text == "") {
            ErrorPassText.SetActive(false);
            ErrorText.SetActive(false);
            ErrorFieldsText.SetActive(true);
            ErrorExistingUsernameText.SetActive(false);
        }
        else {
            StartCoroutine(verifyUser());
        }
    }

    private IEnumerator verifyUser()
    {
        UnityWebRequest userValidationRequest = UnityWebRequest.Get("http://localhost:49184/api/user?username=" + IdLogInput.text + "&password=" + PassLogInput.text);
        yield return userValidationRequest.SendWebRequest();
        if (userValidationRequest.isNetworkError || userValidationRequest.isHttpError)
        {
            Debug.Log("Server error...");
            yield return false;
        }
        if (userValidationRequest.downloadHandler.text != "null")
        {
            StaticClass.username = IdLogInput.text;
            SceneManager.LoadScene(StartScene);
        }
        else
        {
            ErrorPassText.SetActive(false);
            ErrorText.SetActive(true);
            ErrorFieldsText.SetActive(false);
            ErrorExistingUsernameText.SetActive(false);
        }
        yield return true;
    }

    public void registerMethod()
    {
        if (PassRegInput.text == PassConfInput.text)
        {
            if (PassRegInput.text == "" || IdRegInput.text == "")
            {
                ErrorPassText.SetActive(false);
                ErrorText.SetActive(false);
                ErrorFieldsText.SetActive(true);
                ErrorExistingUsernameText.SetActive(false);
            }
            else if (IdRegInput.text != "")
            {
                StartCoroutine(CreateUser());
            }
        }
        else
        {
            ErrorPassText.SetActive(true);
            ErrorText.SetActive(false);
            ErrorFieldsText.SetActive(false);
            ErrorExistingUsernameText.SetActive(false);
        }
    }

    private IEnumerator CreateUser()
    {
        UnityWebRequest newUserRequest = UnityWebRequest.Post("http://localhost:49184/api/user?username=" + IdRegInput.text + "&password=" + PassRegInput.text, "");
        yield return newUserRequest.SendWebRequest();
        if (newUserRequest.isNetworkError || newUserRequest.isHttpError)
        {
            Debug.Log("Server error...");
            yield return false;
        }
        if(newUserRequest.downloadHandler.text != "null")
        {
            Debug.Log(newUserRequest.downloadHandler.text);
            SceneManager.LoadScene(StartScene);
            StaticClass.username = IdRegInput.text;
        }
        else
        {
            ErrorPassText.SetActive(false);
            ErrorText.SetActive(false);
            ErrorFieldsText.SetActive(false);
            ErrorExistingUsernameText.SetActive(true);
        }

    }

    public void quitMethod()
    {
        Debug.Log("Quit Aplication");
        Application.Quit();
    }
}
