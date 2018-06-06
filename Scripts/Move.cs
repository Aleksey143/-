﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public float speed = 0.5f;
	public float distance = 8;
	// Use this for initialization
	void Start () 
	{
		Debug.Log (speed);

	}
	
	// Update is called once per frame
	void Update () 
		{
		if (transform.position.x >= 5 || transform.position.x <= -5)
		{	
			speed = -speed;	
		}	
		transform.Translate (speed,0,0);


	}
}