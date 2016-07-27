using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject enemyGameObject;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn() {
		Instantiate(enemyGameObject, new Vector3(Random.Range (-7, 4), Random.Range (-7, 4), 0), Quaternion.identity);
	}
}
