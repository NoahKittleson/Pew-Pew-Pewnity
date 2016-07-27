using UnityEngine;
using System.Collections;

public class CrappyBird : MonoBehaviour {
	public Rigidbody2D rb;
	public float movespeed;
	public float jumpheight;
	//public Collider2D collider;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		//collider = GetComponent<BoxCollider2D> ();
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
				rb.AddForce (new Vector2 (0, jumpheight), ForceMode2D.Impulse);
		}
	}
}
