﻿using UnityEngine;
using System.Collections;

public class Doodad : ColorObject {
	public float possibleUnderhang;
	public float possibleOverhang;
	public int rarity = 10;
	public float minScale = 0;
	public float maxScale = 0;

	public bool foreground = false;
	public bool sky = false;
	public bool ground = false;
	public bool force = false;
	public bool inGround = false;

	// TODO: Having a public boolean for this is probably lazy
	public bool avoidRegistration = false;

	void Start () {
		if(avoidRegistration) registerWithTintSource();
	}

	void Update() {
		if(!avoidRegistration) changeRenderedColor();
		destroyIfOffscreen();
	}

	public GameObject instantiateAt(Vector3 pos, Quaternion rot) {
		if(sky) pos += new Vector3(gameObject.renderer.bounds.size.x, Random.Range(25, 120), 0);

		return Instantiate(gameObject, pos, rot) as GameObject;
	}
}