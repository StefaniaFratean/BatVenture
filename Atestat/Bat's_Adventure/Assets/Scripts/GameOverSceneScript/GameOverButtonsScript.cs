using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    [SerializeField] private string StartScene;
    public bool waitForStart;

    public void ChangeScene()
    {
        SceneManager.LoadScene(StartScene);
    }
}
