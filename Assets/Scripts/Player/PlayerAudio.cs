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
}
