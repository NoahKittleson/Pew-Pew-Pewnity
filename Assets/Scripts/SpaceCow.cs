using UnityEngine;
using System.Collections;

public class SpaceCow : MonoBehaviour {

	public int health;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Destroy(coll.gameObject);
		} else if (coll.gameObject.tag == "player") {
			health--;
		} else if (coll.gameObject.tag == "lazer" || coll.gameObject.tag == "enemyBullet") {
			health--;
			Destroy(coll.gameObject);
			if (health <=0) {
				Destroy(gameObject);
			}
		}
	}

	// Use this for initialization
	void Start () {
		health = 10;
	}

	// Update is called once per frame
	void Update () {

	}
}