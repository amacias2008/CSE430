using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

	public Transform[] points;
	private Vector3 startingPoint;
	private UnityEngine.AI.NavMeshAgent agent;
	public float patrolSpeed = 1.0f;

	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		startingPoint = agent.transform.position;
		NextPoint ();
	}

	void NextPoint() 
	{
		agent.speed = patrolSpeed;

		Vector3 tempLocalPosition;
		Vector3 tempNextPosition;

		tempLocalPosition = transform.position;
		tempLocalPosition.y = 0f;

		//tempNextPosition.Set (10, 0, 0);
		agent.SetDestination (tempNextPosition.Set(10,0,0));
	}

	// Update is called once per frame
	void Update () 
	{
		NextPoint ();
	}
}
