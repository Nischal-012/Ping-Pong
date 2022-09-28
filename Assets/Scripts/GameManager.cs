using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public SideWall leftWallScript;
	public SideWall rightWallScript;
	public BallControl ballControl;
	public TMP_Text Score1Ui;
	public TMP_Text Score2Ui;
	public TMP_Text winText;
	public GameObject mainMenuButton;


	public void Restart()
	{
		ballControl.ResetPosition();
		ballControl.Invoke("AddStartingForce", 1.0f);
		Debug.Log("Restarted");
	}

	private void Update()
	{
		Score1Ui.text = rightWallScript.playerScore1.ToString();
		Score2Ui.text = leftWallScript.playerScore2.ToString();
		if (rightWallScript.playerScore1 == 10)
		{
			winText.gameObject.SetActive(true);
			mainMenuButton.gameObject.SetActive(true);
			winText.text = "Player 1 Win";
			leftWallScript.buttonRestart.gameObject.SetActive(false);
			rightWallScript.buttonRestart.gameObject.SetActive(false);
		}
		else if (leftWallScript.playerScore2 == 10)
		{
			winText.gameObject.SetActive(true);
			mainMenuButton.gameObject.SetActive(true);
			winText.text = "Player 2 Win";
			leftWallScript.buttonRestart.gameObject.SetActive(false);
			rightWallScript.buttonRestart.gameObject.SetActive(false);
		}

	}
	public void MainMenu()
	{
		SceneManager.LoadScene("Home");
	}
}
