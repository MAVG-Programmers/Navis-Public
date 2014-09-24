using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayerAudio : MonoBehaviour 
{
    public AudioClip attackSound;

    public void PlayClip()
    {
        audio.PlayOneShot(attackSound, 0.7f);
    }



    //public AudioClip[] Clips;

    //private AudioSource[] audioSources;

    //public void Start()
    //{
    //    audioSources = new AudioSource[Clips.Length];

    //    int i = 0;

    //    while (i < Clips.Length)
    //    {

    //        GameObject child = new GameObject("Player");

    //        child.transform.parent = gameObject.transform;

    //        audioSources[i] = child.AddComponent("AudioSource") as AudioSource;

    //        audioSources[i].clip = Clips[i];

    //        i++;

    //    }
    //}

    //void Update()
    //{

    //}

    //public void PlayClip(int clip)
    //{
    //    audioSources[clip].Play();
    //}
}
