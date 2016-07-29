using UnityEngine;
using System.Collections;
using System.Timers;

public class TrainBehaviour : MonoBehaviour {

	public GameObject bullet;
	public Rigidbody2D rb;
	public float currentSpeed;
	public GameController gameController;
	public int health;


	void OnCollisionEnter2D(Collision2D coll) {
		currentSpeed = rb.velocity.sqrMagnitude;
		if (coll.gameObject.tag == "asteroid" && currentSpeed > 20) {
			Destroy (coll.gameObject);
			gameController.increaseScore (5);
		} else if (coll.gameObject.tag == "SpaceCow" && currentSpeed > 20) {
			Destroy(coll.gameObject);
			gameController.increaseScore (10);
		} else if (coll.gameObject.tag == "enemy") {
			Destroy (coll.gameObject);
			gameController.increaseScore (1);
		} else if (coll.gameObject.tag == "enemyBullet") {
			Debug.Log ("Health deducted");
			health--;
			Destroy (coll.gameObject);
			if (health <= 0) {
				Destroy(gameObject);
				gameController.setGameOver();
			}
		}
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
		gameController.setGameOver();
	}	


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		health = 1;
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
