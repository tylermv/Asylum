using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsychController : MonoBehaviour {

	public int psychCounter;

	void Awake () {
	}
	// Use this for initialization
	void Start () {
		psychCounter = 0;
		GameObject.DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void UpdatePsychCounter () {
	
	}

	public void AddPsychCounter (int newPsychCounter) {
		psychCounter = newPsychCounter++;
	}
}
