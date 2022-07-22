using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float panSpeed=11;
    public Transform bat;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = bat.position.x + 15;
        transform.position = pos;

        


        /*
        Vector3 pos = transform.position;
        pos.x += panSpeed * Time.deltaTime;
        pos.z = -106;
        transform.position = pos; 
        */
    }
}
