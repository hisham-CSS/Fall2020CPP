﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody2D rb;

    public float bounceForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (bounceForce <= 0)
        {
            bounceForce = 20.0f;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Squished":
                if (!gameObject.GetComponent<PlayerMovement>().isGrounded)
                {
                    collision.gameObject.GetComponentInParent<EnemyWalker>().IsSquished();
                    rb.velocity = Vector2.zero;
                    rb.AddForce(Vector2.up * bounceForce);
                }
                break;
            case "EnemyProjectile":
                GameManager.instance.lives--;
                Destroy(collision.gameObject);
                break;
        }


        //if (collision.gameObject.tag == "Squished")
        //{
            
        //}

        //if (collision.gameObject.tag == "EnemyProjectile")
        //{
            
        //}
    }

}
