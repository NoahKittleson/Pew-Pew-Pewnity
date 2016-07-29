using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public Text gameOverText;
	public bool gameOver;
	public Text scoreText;
	public int score;

	private bool flip;


	// Use this for initialization
	void Start () {
		gameOverText.text = "";
		flip = true;
		score = 0;
		increaseScore (0);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}
		}
	}

	public void setGameOver() {
		InvokeRepeating("setGameOverText", 0, 3);
		gameOver = true;
	}

	public void increaseScore(int points) {
		score += points;
		scoreText.text = "Score: " + score;
	}

	private void setGameOverText() {
		if (flip) {
			gameOverText.text = "YOU ARE NOW DEAD";
			flip = false;
		} else {
			gameOverText.text = "PRESS DOWN TO RESTART";
			flip = true;
		}
	}
}
