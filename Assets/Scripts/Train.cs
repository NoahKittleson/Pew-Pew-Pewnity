using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {
	public float acceleration;
	public Rigidbody2D rb;
	public float maxSpeed;
	public int track;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	void OnGUI() {
		Event e = Event.current;
		if (e.isKey && Input.GetKeyDown(KeyCode.DownArrow)) {
			changeTrack (-1);
		}

		if (e.isKey && Input.GetKeyDown(KeyCode.UpArrow)) {
			changeTrack (1);
		}
	}

	// Update is called once per frame
	void Update () {
		float speed = rb.velocity.x + acceleration;
		if (speed >= maxSpeed) {
			speed = maxSpeed;
		}
		rb.velocity = new Vector2 (speed, 0);
	}

	private void changeTrack(int change) {
		if ((track + change > 4) || (track + change < 0)) {
			return;
		}
		track += change;
		rb.MovePosition (new Vector2(rb.position.x, (rb.position.y + change * 1)));
	}
}
