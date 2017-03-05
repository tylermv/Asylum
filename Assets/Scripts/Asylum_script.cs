using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Asylum_script : MonoBehaviour {

	public Text text;
	private States myState;
	private enum States {asylum_1, asylum_2};

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.asylum_1) {
			state_asylum_1 ();
		} else if (myState == States.asylum_2) {
			state_asylum_2 ();
		}
	}
		void state_asylum_1 () {
		text.text = "Welcome to the asylum\n\n" +
		"Press Space to continue";

		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.asylum_2;
			}
		}

		void state_asylum_2 () {
		text.text = "Welcome to asylum # 2";
		}
}
