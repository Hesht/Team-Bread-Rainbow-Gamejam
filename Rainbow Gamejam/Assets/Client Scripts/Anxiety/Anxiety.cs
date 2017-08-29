using Assets.Game.Logic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anxiety : MonoBehaviour {
  public GameObject PlayerObject;
  private Camera _camera;

	// Use this for initialization
	void Start () {
    _camera = PlayerObject.GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
    TunnelVision();
	}

  void TunnelVision() {
    float anxiety = 1.0f - GameController.Player.Anxiety;

    _camera.fieldOfView = 60 * anxiety;
  }
}
