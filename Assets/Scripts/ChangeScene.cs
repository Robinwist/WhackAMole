using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	
	public void ChangeToScene (string scenteToChangeTo) {
		Application.LoadLevel (scenteToChangeTo);
	}
}
