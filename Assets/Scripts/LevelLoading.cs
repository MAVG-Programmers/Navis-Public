using UnityEngine;
using System.Collections;

public class LevelLoading : MonoBehaviour 
{
    public GameObject levelBackground;
    public int loadRadius;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void LoadBackgroand(Vector2 position, Quaternion rotation)
    {
        Instantiate(levelBackground, new Vector3(position.x, position.y, 0), rotation);
    }
}
