using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public enum CollectibleType
    {
        POWERUP,
        COLLECTIBLE,
        LIVES,
        KEY
    }

    public CollectibleType currentCollectible;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (currentCollectible)
            {
                case CollectibleType.POWERUP:
                    collision.gameObject.GetComponent<PlayerMovement>().StartJumpForceChange();
                    Destroy(gameObject);
                    break;
                case CollectibleType.COLLECTIBLE:
                    collision.gameObject.GetComponent<PlayerStats>().score++;
                    Destroy(gameObject);
                    break;
                case CollectibleType.LIVES:
                    collision.gameObject.GetComponent<PlayerStats>().lives++;
                    Destroy(gameObject);
                    break;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch(currentCollectible)
            {
                case CollectibleType.KEY:
                    if (Input.GetKeyDown(KeyCode.P))
                    {
                        Debug.Log("You have picked up the key");
                        Destroy(gameObject);
                    }
                    break;
            }
        }
    }
}
