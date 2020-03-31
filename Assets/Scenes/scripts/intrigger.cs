using UnityEngine;

public class intrigger : MonoBehaviour {

	public GameManager gamemanager;
	
	void OnTriggerEnter()
	{
		gamemanager.CompleteLevel();
	}
}
