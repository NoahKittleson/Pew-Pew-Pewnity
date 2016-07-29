using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Touch : MonoBehaviour
{
	private CrappyBird player;
	public GameController gameController;


	void Start()
	{
		player = FindObjectOfType<CrappyBird>();
	}

	public void LeftArrow()
	{
		Debug.Log ("left arrow hit");
		player.moveRight = false;
		player.moveLeft = true;
	}
	public void DownArrow()
	{
		Debug.Log ("down arrow hit");
		player.moveUp = false;
		player.moveDown = true;
		if (gameController.gameOver) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	public void UpArrow()
	{
		Debug.Log ("up arrow hit");
		player.moveDown = false;
		player.moveUp = true;
	}
	public void RightArrow()
	{
		Debug.Log ("right arrow hit");
		player.moveRight = true;
		player.moveLeft = false;
	}
	public void ReleaseLeftArrow()
	{
		Debug.Log ("left arrow released");
		player.moveLeft = false;
	}
	public void ReleaseRightArrow()
	{
		Debug.Log ("right arrow released");
		player.moveRight = false;

	}
	public void ReleaseUpArrow()
	{
		Debug.Log ("up arrow released");
		player.moveUp = false;

	}
	public void ReleaseDownArrow()
	{
		Debug.Log ("down arrow released");
		player.moveDown = false;

	}

}