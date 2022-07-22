using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;
using System.Linq;
using Assets.Scripts.GameOverSceneScript;

public class YourScoreScript : MonoBehaviour
{
    public Text yScoreText;
    public Text Scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        yScoreText.text = "Your score: " + StaticClass.finalScore.ToString();
        Coroutine coroutine = StartCoroutine(UpdateHighscore());
        showScoreboard(coroutine);
    }
    private void showScoreboard(Coroutine coroutine)
    {
        StartCoroutine(GetScoreboard());
        
    }

    private IEnumerator UpdateHighscore()
    {
        UnityWebRequest newUserRequest = UnityWebRequest.Post("http://localhost:49184/api/user/highscore?username=" + StaticClass.username + "&highscore=" + StaticClass.finalScore.ToString(), "");
        yield return newUserRequest.SendWebRequest();
    }

    private IEnumerator GetScoreboard()
    {
         UnityWebRequest newUserRequest = UnityWebRequest.Get("http://localhost:49184/api/user/scoreboard");
        yield return newUserRequest.SendWebRequest();
        List<User> users = JsonConvert.DeserializeObject<List<User>>(newUserRequest.downloadHandler.text);
        string scoreboardtext = "";

        foreach (User u in users)
        {
            if (u.UserName == StaticClass.username && StaticClass.finalScore > u.HighScore)
            {
                u.HighScore = StaticClass.finalScore;
                break;
            }
        }
       
        
        foreach(User u in users.OrderByDescending(u => u.HighScore).ToList())
        {
            scoreboardtext += u.UserName + "............................................." + u.HighScore.ToString() + "\n";
        }


        Scoreboard.text = scoreboardtext;
    }
}
