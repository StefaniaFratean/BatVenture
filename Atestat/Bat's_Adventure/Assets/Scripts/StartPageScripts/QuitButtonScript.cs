﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonScript : MonoBehaviour
{
    public void quitMethod()
    {
        Debug.Log("Quit Aplication");
        Application.Quit();
    }
}
