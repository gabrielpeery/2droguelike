﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public BoardManager boardScript;

	public int level = 3;

	void Awake () {
		boardScript = GetComponent<BoardManager>();
		InitGame();
	}

	void InitGame () {
		boardScript.SetupScene (level);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
