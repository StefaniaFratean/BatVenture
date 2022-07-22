using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class TapController : MonoBehaviour
{
    public float tapForce = 10;
    public float tiltSmooth = 5;
    public Vector3 startPos;

    public Animator animator;
    Rigidbody2D rigidbody;
    Quaternion downRotation;
    Quaternion forwardRotation;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);

    }

    void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = forwardRotation;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
            rigidbody.velocity = Vector3.zero;
            animator.SetBool("IsFlying", true);
        }
        else
        {
              animator.SetBool("IsFlying", false);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    { 
        if(col.gameObject.tag == "ScoreZone")
        {
            //register a score event

        }
        if(col.gameObject.tag == "DeadZone")
        {
            rigidbody.simulated = false;
            //register a death event
        }
    }

}
