using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


	public Vector2 moving = new Vector2 ();
	private float xdir;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		moving.x = moving.y = 0;

		moving.x = Input.GetAxis("Horizontal");
		//Debug.Log (moving.x);

		if(Input.GetButton("Jump")){
			moving.y = 1;
		}//else if (Input.GetKey("down")){
			//moving.y = -1;
		//}
	}
}
