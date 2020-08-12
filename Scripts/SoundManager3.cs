using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager3 : MonoBehaviour {

    public AudioClip soundExplosion3;
    AudioSource myAudio3;

    public static SoundManager3 instance;

    private void Awake()
    {
        if (SoundManager3.instance == null)
            SoundManager3.instance = this;
    }

    // Use this for initialization
    void Start()
    {
        myAudio3 = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        myAudio3.PlayOneShot(soundExplosion3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
