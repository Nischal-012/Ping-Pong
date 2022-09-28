using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
	public Slider volumeSlider;
	public AudioSource audioSource;
	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}
	void OnEnable()
	{
		//Register Slider Events
		volumeSlider.onValueChanged.AddListener(delegate { changeVolume(volumeSlider.value); });
	}

	//Called when Slider is moved
	void changeVolume(float sliderValue)
	{
		audioSource.volume = sliderValue;
	}

}


