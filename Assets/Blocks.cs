using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {

	public static Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}


	void Update () {

		if(transform.position.y <= -17f) //If the blocks gets outs of the screen destroy them
			Destroy(gameObject);



	}
}
