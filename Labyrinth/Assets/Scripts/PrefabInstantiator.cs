﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabInstantiator : MonoBehaviour {

	public GameObject cell;
	public GameObject canvas;
	GameObject newCell;

	int mapHeight, mapWidth;

	List < List <SharedDataTypes.cellType> > map = new List < List <SharedDataTypes.cellType> > ();

	public void getMap (object receivedMap) {
		map = receivedMap as List < List <SharedDataTypes.cellType> >;
	}

	void Awake () {
		
	}

	void Start () {
		
	}

	void Update () {
		if (map == null) {
			return;
		}
		for (int i = 1; i < map.Count - 1; i++) {
			for (int j = 1; j < map [0].Count - 1; j++) {
				newCell = Instantiate (cell, new Vector3 (50 * i, 50 * j), this.transform.rotation);
				newCell.transform.SetParent (canvas.transform, false);
				if (map [i] [j] == SharedDataTypes.cellType.wall) {
					newCell.GetComponent <Image> ().color = Color.blue;
				}
			}
		}
		this.enabled = false;
	}
}