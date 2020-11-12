using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int score;
    public int lives;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;
    }
}
