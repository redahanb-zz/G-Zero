using UnityEngine;
using System.Collections;

public class SimpleController : MonoBehaviour {

	public float 	speed_M, 
					speed_R;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.position += transform.forward * speed_M * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.position -= transform.forward * speed_M * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(Vector3.up * speed_R * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate(-Vector3.up * speed_R * Time.deltaTime);
		}
	}
}
