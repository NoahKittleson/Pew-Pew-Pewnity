using UnityEngine;
using System.Collections;

public class CrappyBird : MonoBehaviour {
	public Rigidbody2D rb;
	public float movespeed;
	public float jumpheight;

	public bool moveRight;
	public bool moveLeft;
	public bool moveDown;
	public bool moveUp;
	//public Collider2D collider;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		//collider = GetComponent<BoxCollider2D> ();
	}

	void Update () {

		if (moveRight)
		{
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
		if (moveUp) {
			rb.AddForce (new Vector2 (0, jumpheight), ForceMode2D.Impulse);
		}
		if (moveDown) {
			//nothing yet....
		}
		if (moveLeft)
		{
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
		}

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
