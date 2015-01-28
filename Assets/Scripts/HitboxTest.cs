using UnityEngine;
using System.Collections;

public class HitboxTest : MonoBehaviour {

	private Score scoreScript;
	private GameObject ScoreObject;
	private MoleBehaviour behaviour;

	void Start()
	{
		ScoreObject = GameObject.Find("GameManager");
		scoreScript = ScoreObject.GetComponent<Score>();

		behaviour = GetComponent<MoleBehaviour>();
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.transform.tag == "Hammer")
		{
			behaviour.thisState = State.knocked;
			scoreScript.UpdateScore(1);
		}
	}
}