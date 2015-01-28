using UnityEngine;
using System.Collections;

public class HitboxTest : MonoBehaviour {

	private Score scoreScript;
	private GameObject ScoreObject;

	void Start()
	{
		ScoreObject = GameObject.Find("GameManager");
		scoreScript = ScoreObject.GetComponent<Score>();
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.transform.tag == "Hammer")
		{
			Debug.Log("HAMMER TIME!!");
			scoreScript.UpdateScore(1);
		}
	}
}