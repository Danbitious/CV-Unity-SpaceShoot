﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Mover: MonoBehaviour 
//{
//	public float speed;
//
//	void start ()
//	{
//	GetComponent<Rigidbody>().velocity = transform.up * speed;
//	}
//}


public class Mover: MonoBehaviour
{
	public float speed;
	public Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up * speed;
	}
}