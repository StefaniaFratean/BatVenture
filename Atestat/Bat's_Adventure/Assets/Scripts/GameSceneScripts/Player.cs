using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;

    [SerializeField] private LayerMask Stalactite;
    private Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;
    public Animator animator;
    private float moveSpeed = 11;


    private character_movement characterMovement;
    

    private void Awake()
    {
        instance = this;
        characterMovement = gameObject.GetComponent<character_movement>();
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        Movement();
    }


    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void Movement()
    {
        if (StaticClass.scoreValue > 0f && StaticClass.scoreValue < 50f)
        {
            if(StaticClass.scoreValue % 10 == 0)
            {
                moveSpeed = moveSpeed + moveSpeed * StaticClass.scoreValue * 0.0002f;
            }
        }
        rigidbody2D.velocity = new Vector2(+moveSpeed, rigidbody2D.velocity.y);
    }


    private void Die()
    {
        rigidbody2D.velocity = Vector3.zero;
    }

    public static void Die_static()
    {
        instance.Die();
        //GameOverWindow.Show();
    }

    void OnScoreZoneEnter2d(Collision2D col)
    {
        StaticClass.scoreValue += 1;
    }




}
