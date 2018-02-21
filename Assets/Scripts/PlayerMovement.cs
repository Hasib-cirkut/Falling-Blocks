using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D rb;
	public float thrust;
	public float ScreenWidth;
	//public GameObject Player;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * thrust;

		Vector2 NewPos = rb.position + Vector2.right * x;

		NewPos.x = Mathf.Clamp(NewPos.x,  -ScreenWidth, ScreenWidth);

		rb.MovePosition( NewPos);

	}

	void OnCollisionEnter2D()
	{
		FindObjectOfType<GameManager>().EndGame();
	}
}
