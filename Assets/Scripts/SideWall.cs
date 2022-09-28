
using UnityEngine;

public class SideWall : MonoBehaviour
{
	public int playerScore1 = 0;
	public int playerScore2 = 0;
	public AudioSource audio1;
	public GameObject buttonRestart;

	private void Start()
	{
		buttonRestart.gameObject.SetActive(false);
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{

		if (gameObject.name == "Right Wall")
		{
			Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
			playerScore1++;
			audio1.Play();
			Debug.Log(playerScore1);
		}
		else if (gameObject.name == "Left Wall")
		{
			Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
			playerScore2++;
			audio1.Play();
			Debug.Log(playerScore2);
		}
		buttonRestart.gameObject.SetActive(true);
	}
}