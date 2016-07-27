using UnityEngine;
using System.Collections;
using System.Timers;
public class TrainBehaviour : MonoBehaviour {

    public GameObject player;	
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "asteroid") {
			Destroy(coll.gameObject);
		}

		// if (coll.gameObject.tag == "cow") {
		// 	Timer timer = new Timer(1000);
		// 	timer.Start();
		// 	if (timer.Elapsed() >= 2000) {
		// 		Destroy(coll.gameObject);
		// 	}
		// }
	}


	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
