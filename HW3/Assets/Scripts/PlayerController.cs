using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public KeyCode moveForward;
	public KeyCode moveLeft;
	public KeyCode moveRight;
	public KeyCode moveBackward;
	public KeyCode moveJump;
	private Rigidbody rb;
	private float speed;

	//use this for important initialization
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		speed = 5.0f;
	}

	//use this for initialization
	void Start()
	{
	}
	//update is called once per frame
	void Update() 
	{
		Movement ();
		Jump ();
	}

	void Jump() 
	{
		if (Input.GetKeyDown (moveJump)) 
		{
			rb.AddForce (Vector3.up * 75.0f);
		}
	}

	void Movement()
	{
		//moves the player forward
		if (Input.GetKey(moveForward)) 
		{
			rb.velocity = Vector3.forward * speed;
			//transform.Translate (Vector3.forward);
		}
		if (Input.GetKey(moveLeft)) 
		{
			rb.velocity = Vector3.left * speed;
			//transform.Translate (Vector3.left);
		}
		if (Input.GetKey(moveRight)) 
		{
			rb.velocity = Vector3.right * speed;
			//transform.Translate (Vector3.right);
		}
		if (Input.GetKey(moveBackward)) 
		{
			rb.velocity = Vector3.back * speed;
			//transform.Translate (Vector3.back);
		}
	}
}
