using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {

	public int speed = 4;
	public Rigidbody2D r2d;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "asteroid") {
			Destroy(gameObject);
		} else if (coll.gameObject.tag == "enemy") {
			Destroy(coll.gameObject);
		}
	}


	void Start () {
		r2d = GetComponent<Rigidbody2D>();

		r2d.velocity = new Vector2(speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}
