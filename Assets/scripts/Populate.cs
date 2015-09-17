using UnityEngine;
using System.Collections;

public class Populate : MonoBehaviour {
	
	Planet[] planets;
	float realDiam = 1391000.0f;
	float scale;
	public Transform planetPref;
	public Transform labelPref;
	
	
	// Use this for initialization
	void Start () {
		scale = transform.localScale.x / realDiam;
		planets = new Planet[] {
			new Planet(57.9f, 88.0f, 4222.6f, 4879.0f, 7.0f, "Mercury"),
			new Planet(108.2f, 224.7f, 2802.0f, 12104.0f, 3.4f, "Venus"),
			new Planet(149.6f, 365.2f, 24.0f, 12756.0f, 0.0f, "Earth"),
			new Planet(227.9f, 687.0f, 24.7f, 6792.0f, 1.9f, "Mars"),
			new Planet(778.6f, 4331.0f, 9.9f, 142984.0f, 1.3f, "Jupiter"),
			new Planet(1433.5f, 10747.0f, 10.7f, 120536.0f, 2.5f, "Saturn"),
			new Planet(2872.5f, 30589.0f, 17.2f, 51118.0f, 0.8f, "Uranus"),
			new Planet(4495.1f, 59800.0f, 16.1f, 49528.0f, 1.8f, "Neptune")
		};
		foreach(var planet in planets) {
			Transform newPlanet = (Transform)Instantiate(planetPref);
			Transform label = (Transform)Instantiate(labelPref);
			newPlanet.parent = this.transform;
			label.parent = newPlanet;
			newPlanet.localPosition = Vector3.zero;
			newPlanet.BroadcastMessage("SetScale", scale);
			newPlanet.BroadcastMessage("SetLabel", label);
			newPlanet.BroadcastMessage("InitPlanet", planet);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
