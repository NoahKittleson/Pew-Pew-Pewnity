using UnityEngine;
using System.Collections;

public class SpaceCow : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Destroy(coll.gameObject);
		} else if (coll.gameObject.tag == "player") {
			Destroy(coll.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
