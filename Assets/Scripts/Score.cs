using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	private int score;
	public Text scoreCount;

	void Start()
	{
		score = 0;
	}

	void Update()
	{
		scoreCount.text = "Score: " + score.ToString();
	}

	public void UpdateScore(int amount)
	{
		//Add Score
		score += amount;
	}
}
