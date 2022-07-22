using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathZoneScript : MonoBehaviour
{
    [SerializeField] private string GameOverScene;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            SceneManager.LoadScene(GameOverScene);
            Score.restartScore();
        }
    }
}
