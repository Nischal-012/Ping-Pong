using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	private AudioSource menuSound;

	private void Awake()
	{
		menuSound = GetComponent<AudioSource>();
	}
	public void Play()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit()
	{
		Application.Quit();
	}

	public void SoundPlay()
	{
		menuSound.Play();
	}
}
