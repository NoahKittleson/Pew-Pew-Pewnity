using UnityEngine;
using System.Collections;

public class EnemyBulletBehaviour : MonoBehaviour {

	public int speedX;
	public int speedY;
	public Rigidbody2D r2d;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "asteroid") {
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		// Get the rigidbody component
		r2d = GetComponent<Rigidbody2D>();
		speedX = Random.Range(-5, 5);
		speedY = Random.Range(-5, 5);
		r2d.velocity = new Vector2(speedX, speedY);
	}

	// Update is called once per frame
	void Update () {
	}
	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}
