using UnityEngine;
using System.Collections;

public enum State
{
	movingUp,
	movingDown,
	rest,
	knocked,
	cooldown
}

public class MoleBehaviour : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 topPos;
	public Vector3 botPos;

	public State thisState;

	void Start()
	{
		SetState(thisState);
	}

	IEnumerator MoveUp()
	{
		thisState = State.movingUp;

		float t = 0;
		while(t < 1 && thisState == State.movingUp)
		{
			yield return null;
			t += Time.deltaTime / 0.55f;
			this.transform.position = Vector3.Lerp(botPos, topPos, t);
		}
			SetState(State.cooldown);
	}

	IEnumerator MoveDown()
	{
		thisState = State.movingDown;
		
		float t = 0;
		while(t < 1)
		{
			yield return null;
			t += Time.deltaTime / 0.55f;
			
			this.transform.position = Vector3.Lerp(topPos, botPos, t);
		}
			SetState(State.movingUp);
	}

	IEnumerator Knocked()
	{
		thisState = State.knocked;

		float t = 0;
		while(t < 1)
		{
			yield return null;
			t += Time.deltaTime / 0.55f;

			this.transform.position = Vector3.Lerp(topPos, botPos, t);
		}
			SetState(State.rest);
	}

	IEnumerator Cooldown()
	{
		thisState = State.cooldown;

		float t = 0;
		while(t < Random.Range(0, 5))
		{
			yield return null;
			t += Time.deltaTime;
		}
		SetState(State.movingDown);
	}

	IEnumerator Rest()
	{
		thisState = State.rest;
		
		float t = 0;
		while(t < 4.5f)
		{
			yield return null;
			t += Time.deltaTime;

			this.transform.position = Vector3.Lerp(topPos, botPos, t);
		}
		SetState(State.movingDown);
	}

	void SetState(State state)
	{
		if(state == State.rest)
		{
			StartCoroutine(Rest());
		}
		else if(state == State.knocked)
		{
			StartCoroutine(Knocked());
		}
		else if(state == State.movingUp)
		{
			StartCoroutine(MoveUp());
		}
		else if(state == State.movingDown)
		{
			StartCoroutine(MoveDown());
		}
		else if(state == State.cooldown)
		{
			StartCoroutine(Cooldown());
		}
	}
}