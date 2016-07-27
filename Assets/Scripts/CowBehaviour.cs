using UnityEngine;
using System.Collections;

public class CowBehaviour : MonoBehaviour {


    public GameObject bullet;
	
	void Start () {
        InvokeRepeating("FireBullet", 1, 3);
	}
	
	
	void Update () {

	}

    void FireBullet () {
		Instantiate(bullet, new Vector2(transform.position.x - 1,transform.position.y), Quaternion.identity);
    }

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}
