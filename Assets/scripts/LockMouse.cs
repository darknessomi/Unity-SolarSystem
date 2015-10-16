using UnityEngine;
using System.Collections;

public class LockMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape)) {
			Screen.lockCursor = false;
		}
		if (Input.GetKey(KeyCode.Return)) {
			Screen.lockCursor = true;
		}
		if (Input.GetKey(KeyCode.F1)) {
			Application.LoadLevel("Menu");
			Screen.lockCursor = false;
		}
	}
}
