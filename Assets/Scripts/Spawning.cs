using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject enemyGameObject;
	public GameObject enemyGameObject2;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1, 1);
		InvokeRepeating("SpawnSpaceCow", 10, 30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn() {
		Instantiate(enemyGameObject, new Vector3(Random.Range (-7, 9), Random.Range (-3, 4), 0), Quaternion.identity);
	}

	void SpawnSpaceCow() {
		Instantiate(enemyGameObject2, new Vector3(Random.Range (-7, 9), Random.Range (-3, 4), 0), Quaternion.identity);
	}
}
