using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player)
        {
            Vector3 cameraTransform;
            cameraTransform = transform.position;
            cameraTransform.x = player.transform.position.x - 0.5f;
            cameraTransform.x = Mathf.Clamp(cameraTransform.x, -0.12f, 46.01f);
            transform.position = cameraTransform;
        }
    }
}
