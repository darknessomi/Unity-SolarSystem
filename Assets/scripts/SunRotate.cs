using UnityEngine;
using System.Collections;

public class SunRotate : MonoBehaviour {
	
	Vector3 rot;
	// Use this for initialization
	void Start () {
		rot = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(rot, 1.0f);
	}
}
