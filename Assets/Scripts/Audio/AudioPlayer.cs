using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour
{
    private AudioClip clip;
    public AudioClip Clip 
    { 
        get
        {
            return clip;
        }
        set 
        {
            clip = value;
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
}
