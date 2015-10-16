using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public static bool first_load = true;

	public GameObject GUIC;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		GUIC.GetComponent<AudioSource> ().volume = Settings.music;
		AudioListener.volume = Settings.volume;
	}

	public void ContinueGame () {
		if (first_load != true) {
			Application.LoadLevel("Solar");
		}
	}

	public void NewGame () {
		first_load = false;
		Time.timeScale = 0;
		Application.LoadLevel("Solar");
		Time.timeScale = 1;
	}

}
