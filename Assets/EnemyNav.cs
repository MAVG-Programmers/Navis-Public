using UnityEngine;
using System.Collections;

public class EnemyNav : MonoBehaviour {
	public Transform target;

	NavMeshAgent agent;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		agent = GetComponent<NavMeshAgent>();
		agent.destination = target.position;
	}
}
