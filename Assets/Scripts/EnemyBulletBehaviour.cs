using UnityEngine;
using System.Collections;

public class EnemyBulletBehaviour : MonoBehaviour {

	public int speed = -5;
	public Rigidbody2D r2d;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "asteroid" || coll.gameObject.tag == "player") {
			Destroy(gameObject);
		} 
	}

	// Use this for initialization
	void Start () {
		// Get the rigidbody component
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
