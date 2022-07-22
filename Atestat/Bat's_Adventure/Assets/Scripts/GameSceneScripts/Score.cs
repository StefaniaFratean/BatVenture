using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    void Start()
    {
        StaticClass.text = GetComponent<Text>();    
    }

    void Update()
    {
        StaticClass.text.text = StaticClass.scoreValue.ToString();
    }

    public static void restartScore()
    {
        StaticClass.text.text = "0";
        StaticClass.finalScore = StaticClass.scoreValue;
        StaticClass.scoreValue = 0;
    }
}
