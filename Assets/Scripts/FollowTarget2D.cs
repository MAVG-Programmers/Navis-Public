﻿using UnityEngine;
using System.Collections;

public class FollowTarget2D : MonoBehaviour 
{
	
	public Transform target;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
	}
}
