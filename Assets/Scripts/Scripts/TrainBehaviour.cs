using UnityEngine;
using System.Collections;
using System.Timers;
public class TrainBehaviour : MonoBehaviour {
	
	public GameObject bullet;
	public float currentSpeed;
	public Rigidbody2D trainSpeed;

	void OnCollisionEnter2D(Collision2D coll) {
		currentSpeed = trainSpeed.velocity.sqrMagnitude;
		if (coll.gameObject.tag == "asteroid" && currentSpeed > 20) {
			Destroy(coll.gameObject);
		} else if (coll.gameObject.tag == "enemy") {
			Destroy(coll.gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		trainSpeed = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			// Create a new bullet at “transform.position” 
			// Which is the current position of the ship
			// Quaternion.identity = add the bullet with no rotation
			Instantiate(bullet, new Vector2(transform.position.x + 2,transform.position.y), Quaternion.identity);
		}
	}
}
