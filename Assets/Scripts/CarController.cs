using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public bool moving = false;
	public float speed = 1f;

	private bool signaledToMove = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (moving && signaledToMove) 
		{
			this.GetComponent<Rigidbody>().AddForce(Vector3.back * 250 * speed);
		}

		//Destroy train for better performance
		if (this.gameObject.transform.position.z < -520 ||
			this.gameObject.transform.position.y < -20)
			{
				Destroy(this.gameObject);
			}
	}

	public void SignalToMove()
	{
		this.signaledToMove = true;
	}


}
