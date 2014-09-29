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

        get
        {
            return volume;
        }
    }

    public void PlayClip(AudioClip clip)
    {
        audio.PlayOneShot(clip, volume);
    }

    public AudioSource AddSource(AudioClip clip, bool loop)
    {
        AudioSource source = gameObject.AddComponent<AudioSource>();

        source.clip = clip;
        source.loop = loop;
        source.volume = volume;

        return source;
    }

    public void FadeOut(AudioSource source, float speed)
    {
        StartCoroutine(FadeSource(source, speed, true));
    }

    public void FadeIn(AudioSource source, float speed)
    {
        StartCoroutine(FadeSource(source, speed, false));
    }

    IEnumerator FadeSource(AudioSource source, float speed, bool fadeOut)
    {
        if (fadeOut)
        {
            while (source.volume > 0)
            {
                source.volume -= Time.deltaTime;                
                yield return new WaitForSeconds(speed);
            }
        }
        if (!fadeOut)
        {
            while (source.volume < volume)
            {
                source.volume += Time.deltaTime;
                yield return new WaitForSeconds(speed);
            }
        }
    }
}
