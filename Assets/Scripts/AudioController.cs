using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip intro;
    public AudioClip BGM;

    void Start()
    {
        StartCoroutine(introAndBGM());
    }

    
    public IEnumerator introAndBGM()
    {
        AudioSource audio = GetComponent<AudioSource>();
        //Intro music plays for 10.0 second and stop (doesnt loop) just before BGM comes out
        audio.clip = intro; 
        audio.loop = false;
        audio.Play();
        yield return new WaitForSeconds (10.0f);
        audio.Stop();

        // After 10.0 second play (Intro mushic finished BGM comes out and it loops)
        audio.clip = BGM;
        audio.loop = true;
        audio.Play();
    }
}
