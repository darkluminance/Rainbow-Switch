using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour {
	public Rigidbody2D rbd;
	public float speed;
	public GameObject button, gamelogo, blackbg;
	

	public void startkoro(){
			rbd.velocity = (Random.insideUnitCircle).normalized * speed;
			gameObject.GetComponent<addforce>().enabled = false;
			button.SetActive(false); gamelogo.SetActive(false); blackbg.SetActive(false);
	}
}
