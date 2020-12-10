using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    //    if (!playerFireSource)
    //        playerFireSource = GameObject.FindGameObjectWithTag("Player").GetComponents<AudioSource>()[0];

    //    if (!playerJumpSource)
    //        playerJumpSource = GameObject.FindGameObjectWithTag("Player").GetComponents<AudioSource>()[1];
    }
    
    public void PlayerSound(AudioSource currentAudio)
    {
        currentAudio.Play();
        //if (currentAudio.name == "Plame Ball SFX")
        //{
        //    playerFireSource.clip = currentAudio;
        //    playerFireSource.loop = isLooping;
        //    playerFireSource.Play();
        //}
        //else
        //{
        //    playerJumpSource.clip = currentAudio;
        //    playerJumpSource.loop = isLooping;
        //    playerJumpSource.Play();
        //}

        //for (int i = 0; i < playerAudioSource.Length; i++)
        //{
        //    if (playerAudioSource[i].isPlaying)
        //    {
        //        continue;
        //    }
        //    else
        //    {
        //        playerAudioSource[i].clip = currentAudio;
        //        playerAudioSource[i].loop = isLooping;
        //        playerAudioSource[i].Play();
        //        break;
        //    }
        //}

    }

}
