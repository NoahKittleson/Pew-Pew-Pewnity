using UnityEngine;
using System.Collections;
using System.Timers;
public class TrainBehaviour : MonoBehaviour {

	public GameObject bullet;
	public Rigidbody2D rb;
	public float currentSpeed;
	public int health;

	void OnCollisionEnter2D(Collision2D coll) {
		currentSpeed = rb.velocity.sqrMagnitude;
		if (coll.gameObject.tag == "asteroid" && currentSpeed > 20) {
			Destroy(coll.gameObject);
		} else if (coll.gameObject.tag == "enemy") {
			Destroy(coll.gameObject);
		} else if (coll.gameObject.tag == "enemyBullet") {
			health--; 
			if (health <= 0) {
				Destroy(gameObject);
			}
		}
	}


	// Use this for initialization
	void Start () {
		health = 10;
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Create a new bullet at “transform.position” 
			// Which is the current position of the ship
			// Quaternion.identity = add the bullet with no rotation
			Instantiate (bullet, new Vector2 (transform.position.x + 2, transform.position.y), Quaternion.identity);
		}
	}
}
