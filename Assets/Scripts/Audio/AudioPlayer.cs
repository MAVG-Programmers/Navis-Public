using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour
{
    private float volume = 0.7f;
    public float Volume
    {
        set
        {
            volume = value;
        }
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void PlayClip(AudioClip clip)
    {
        audio.PlayOneShot(clip, volume);
    }

    public AudioSource PlaySource(AudioClip clip, bool loop)
    {
        AudioSource source = gameObject.AddComponent<AudioSource>();

        source.volume = volume;
        source.clip = clip;
        source.loop = loop;
        source.volume = volume;

        return source;
    }
}
