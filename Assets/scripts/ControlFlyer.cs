using UnityEngine;
using System.Collections;

public class ControlFlyer : MonoBehaviour {
//	public float moveSpeed;
//	public float lookSpeed;
	float rotationX = 0.0f;
	float rotationY = 0.0f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		rotationX += Input.GetAxis("Mouse X")*Settings.lookSpeed;
		rotationY += Input.GetAxis("Mouse Y")*Settings.lookSpeed;
		rotationY = Mathf.Clamp (rotationY, -90, 90);
	 
		transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
		transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);
	 
		transform.position += transform.forward*Settings.moveSpeed*Input.GetAxis("Vertical");
		transform.position += transform.right*Settings.moveSpeed*Input.GetAxis("Horizontal");
		transform.position += transform.up*(Input.GetKey(KeyCode.R) ? Settings.moveSpeed : 0.0f);
		transform.position += -1.0f*transform.up*(Input.GetKey(KeyCode.F) ? Settings.moveSpeed : 0.0f);
	}
}
