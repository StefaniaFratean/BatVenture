﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAreaScript : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            StaticClass.scoreValue += 1;

            Debug.Log("+1");
        }
        
    }
}
