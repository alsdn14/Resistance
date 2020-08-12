using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager2 : MonoBehaviour
{


    public AudioClip soundExplosion2;
    AudioSource myAudio2;

    public static SoundManager2 instance;

    private void Awake()
    {
        if (SoundManager2.instance == null)
            SoundManager2.instance = this;
    }

    // Use this for initialization
    void Start()
    {
        myAudio2 = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        myAudio2.PlayOneShot(soundExplosion2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
