using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public float timer = 5f;
	public Text Countdown;

	void Start()
	{
		//
	}

	void Update()
	{
		timer -= Time.deltaTime;
		Countdown.text = "Time Left: " + timer.ToString("f0");

		if(timer < 0)
		{
			timer = 0f;
			Time.timeScale = 0f;
			Input.ResetInputAxes();

			//Countdown.text = "TIME'S UP!";
			Debug.Log("Time's Up!");
		}
	}

}
