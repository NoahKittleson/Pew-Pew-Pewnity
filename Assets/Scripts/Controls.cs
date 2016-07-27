using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public Rigidbody2D rb;
	public float movespeed;
	public float jumpheight;
	public float maxVelocity = 200;
	public Collider2D collider;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		collider = GetComponent<BoxCollider2D> ();
	}

	void Update () {
			
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb.velocity = new Vector2(rb.velocity.x - movespeed, rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb.velocity = new Vector2(rb.velocity.x + movespeed, rb.velocity.y);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (rb.velocity.y == 0) {
				rb.AddForce (new Vector2 (0, jumpheight), ForceMode2D.Impulse);
			} else {
				
			}
		}

		if (rb.velocity.x > maxVelocity) {
			rb.velocity = new Vector2 (maxVelocity, rb.velocity.y);
		} else if (rb.velocity.x < -maxVelocity) {
			rb.velocity = new Vector2 (-maxVelocity, rb.velocity.y);
		}
	}
}
