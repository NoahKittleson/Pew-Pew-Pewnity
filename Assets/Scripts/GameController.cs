using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public Text gameOverText;
	public bool gameOver;

	private bool flip;


	// Use this for initialization
	void Start () {
		gameOverText.text = "";
		flip = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}
		}
	}

	public void setGameOver() {
		InvokeRepeating("setGameOverText", 0, 3);
		gameOver = true;
	}

	private void setGameOverText() {
		if (flip) {
			gameOverText.text = "YOU ARE NOW DEAD";
			flip = false;
		} else {
			gameOverText.text = "PRESS R TO RESTART";
			flip = true;
		}
	}
}
