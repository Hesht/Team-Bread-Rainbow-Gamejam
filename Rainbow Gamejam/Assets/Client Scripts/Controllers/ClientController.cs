﻿using Assets.Game.Logic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    GameController.Update();
	}
}