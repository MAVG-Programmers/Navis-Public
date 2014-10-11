using UnityEngine;
using System.Collections;

public class DeleteFarAwayObjects : MonoBehaviour {

	public float maxDistance = 50;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		object[] objects = GameObject.FindObjectsOfType(typeof (GameObject));

		foreach (GameObject obj in objects) {
			if((obj.transform.position - gameObject.transform.position).magnitude > maxDistance && obj.tag != "Background")
			{
				Destroy (obj);
			}
		}
	}
}
