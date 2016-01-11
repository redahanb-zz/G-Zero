using UnityEngine;
using System.Collections;

public class StickToSurface : MonoBehaviour {
	
	RaycastHit rayHit;
	public Vector3 surfaceNormal;
	public float gravSpeed;
	Rigidbody rigidBody;

	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.DrawRay (transform.position, -transform.up*5.0f);

		if (Physics.Raycast (transform.position, -transform.up, out rayHit, 5.0f) && rayHit.collider.tag == "Planetoid") 
		{
			surfaceNormal = rayHit.normal;

			//transform.position = rayHit.point + rayHit.normal*0.5f;
			transform.position = rayHit.point + rayHit.normal;
			rigidBody.AddForce (-transform.up * gravSpeed * Time.deltaTime);
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.LookRotation (Vector3.Cross (transform.right, rayHit.normal), rayHit.normal), Time.deltaTime * 15.0f);
		} 
		else 
		{
			rigidBody.useGravity = true;
		}
	}
}
