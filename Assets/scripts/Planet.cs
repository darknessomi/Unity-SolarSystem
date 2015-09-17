using UnityEngine;
using System.Collections;

public class Planet {

	public float distance6;
	public float orbPeriod;
	public float dayLength;
	public float diameter;
	public float inclination;
	public string name;
	
	public Planet(float distSun, float orbPer, float dayL, float diam, float incl, string n) {
		distance6 = distSun;
		orbPeriod = orbPer;
		dayLength = dayL;
		diameter = diam;
		inclination = incl;
		name = n;
	}
}
