using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Settings : MonoBehaviour {

	public static float moveSpeed = 0.4f;

	public static float lookSpeed = 5;

	public static float music = 0.8f;

	public static float volume = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void moveSpeed_slider (float speed) {
		moveSpeed = speed;
	}

	public void lookSpeed_slider (float speed) {
		lookSpeed = speed;
	}

	public void music_slider (float v) {
		music = v;
	}

	public void volume_slider (float v) {
		volume = v;
	}
}
