using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButtonsScript : MonoBehaviour
{
    [SerializeField] private string StartScene;
    [SerializeField] private string LoginScene;
    public bool waitForStart;

    public void ChangeScene()
    {
        StaticClass.scoreValue = 0;
        StaticClass.text.text = StaticClass.scoreValue.ToString();
        SceneManager.LoadScene(StartScene);
    }
    public void Logout()
    {
        StaticClass.scoreValue = 0;
        SceneManager.LoadScene(LoginScene);
    }
}
