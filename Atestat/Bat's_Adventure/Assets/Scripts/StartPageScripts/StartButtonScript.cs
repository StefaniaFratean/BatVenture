using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    [SerializeField] private string GameScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(GameScene);
        StaticClass.scoreValue = 0;
        if(StaticClass.text.text == null)
        {
            StaticClass.text.text = StaticClass.scoreValue.ToString();
        }
        
    }
}

