﻿using UnityEngine;
using System.Collections.Generic;

public class Doodads : MonoBehaviour {
	public static Doodads Instance;
	
	public GameObject[] doodads;
	private DoodadScript[] scripts;

	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of Doodads!");
		}
		Instance = this;

		List<DoodadScript> list = new List<DoodadScript>();
		foreach(GameObject doodad in doodads) {
			list.Add(doodad.GetComponent<DoodadScript>());
		}
		scripts = list.ToArray();
	}

	public float getRandomOffset(int doodadIndex)
	{
		return Random.Range (10, 40);
//		return doodads[doodadIndex].renderer.bounds.size.y * 
//			Random.Range (scripts[doodadIndex].possibleUnderhang, scripts[doodadIndex].possibleOverhang);
	}
}