using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{	
	public GameObject Player;
	public GameObject TheCamera;
	
	void Start ()
    {		
		Player = Resources.Load <GameObject>("Prefabs/PlayerPrefabs/Serenity");
		GameObject PlayerClone = (GameObject) Instantiate (Player);
		

        TheCamera = (GameObject)Instantiate(Resources.Load<GameObject>("Prefabs/MainCamera"));
        TheCamera.GetComponent<MainCamera>().target = PlayerClone.transform;
	}
	
	
	void Update () 
    {
		
	}
}
