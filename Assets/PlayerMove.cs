using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float speed, moveH;

	

	
	// Update is called once per frame
	void Update () {
		moveH = SimpleInput.GetAxis("Horizontal");
		}

	private void FixedUpdate()
	{
		transform.RotateAround(Vector3.zero, Vector3.forward , moveH * -speed * Time.deltaTime);
	}
}
