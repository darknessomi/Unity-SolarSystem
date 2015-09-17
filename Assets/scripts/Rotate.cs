using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	float maxX;
	float maxY;
	float rotationX;
	float rotatonY;
	float speed;
	float rotSpeed;
	
	float scale;
	bool started = false;
	
	Transform label;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(started) {
			var angle = speed * Time.fixedTime;
			this.transform.localPosition = new Vector3(maxX * Mathf.Cos(angle), 0, maxY * Mathf.Sin(angle));
			label.localPosition = this.transform.localPosition + Vector3.down * 2;
			//this.transform.Rotate(Vector3.forward * (angle - prevAngle));
			this.transform.Rotate(Vector3.up, rotSpeed);
		}
	}
	
	void SetScale(float s) {
		scale = s;
	}
	
	void SetLabel(Transform p) {
		label = p;
	}
	
	void InitPlanet(Planet p) {
		//Debug.Log (p);
		this.transform.parent.Rotate(new Vector3(0.0f, 0.0f, p.inclination));
		maxX = maxY = p.distance6 * scale * 20000; //50 times closer to sun!
		speed = 3 / p.orbPeriod;
		rotSpeed = 24 / p.dayLength;
		this.transform.localScale = Vector3.one * p.diameter * scale;
		label.localScale = Vector3.one * Mathf.Sqrt(p.distance6) * 0.5f;
		(label.GetComponent("TextMesh") as TextMesh).text = p.name;
		/*var www = new WWW("file://"+Application.dataPath + "/Textures/" + p.name.ToLower() + ".jpg");
		while (www.isDone != true);
		renderer.material.mainTexture = new Texture2D(1024, 512);
		www.LoadImageIntoTexture(renderer.material.mainTexture as Texture2D);*/
		GetComponent<Renderer>().material.mainTexture = Resources.Load(p.name.ToLower()) as Texture2D;
		started = true;
	}
}
