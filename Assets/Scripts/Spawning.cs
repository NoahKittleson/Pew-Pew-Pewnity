using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject enemyGameObject;
	public GameObject enemyGameObject2;
	public GameObject asteroid;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1, 0.5f);
		InvokeRepeating("SpawnSpaceCow", 10, 10);
		InvokeRepeating("SpawnAsteroid", 12, 20);
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

	void SpawnAsteroid() {
		Instantiate(asteroid, new Vector3(Random.Range (-7, 9), Random.Range (-3, 4), 0), Quaternion.identity);
	}
}
