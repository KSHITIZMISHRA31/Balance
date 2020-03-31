using UnityEngine;

public class Move : MonoBehaviour {
	public Rigidbody rb;

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,2000*Time.deltaTime);
		
		if(Input.GetKey("a"))
		{
			rb.AddForce(-100*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("d"))
		{
			rb.AddForce(100*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(rb.position.y < -1f)
		{
				FindObjectOfType<GameManager>().EndGame();
		}
		
		
	}
}
