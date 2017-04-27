﻿using UnityEngine;

public class GravityFromAccelerometer : MonoBehaviour {

	// gravity constant
	public float g=9.8f;

	void Update() {
		// normalize axis
		Physics.gravity=new Vector3( 
			Input.acceleration.x,
			0,
			-Input.acceleration.z
		)*g;
	}

}