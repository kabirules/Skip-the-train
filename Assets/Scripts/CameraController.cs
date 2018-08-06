using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	bool cameraAttached = true;

	// Use this for initialization
	void Start () 
	{
		Vector3 playerPosition = player.transform.position;
		this.gameObject.transform.position = new Vector3(playerPosition.x,
															playerPosition.y + 2.2f,
															playerPosition.z - 4f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cameraAttached)
		{
			Vector3 playerPosition = player.transform.position;
			this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,
															this.gameObject.transform.position.y,
															playerPosition.z - 4f);
		}
	}

	public void AdjustCamera(float xValue)
	{
		this.gameObject.transform.Translate(xValue, 0, 0);
	}

	public void DetachCamera() 
	{
		cameraAttached = false;
	}
}
