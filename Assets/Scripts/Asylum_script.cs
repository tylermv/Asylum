using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Asylum_script : MonoBehaviour {

	public Text text;
	private States myState;
	private enum States {asylum_1, asylum_2, solitary_1, desk, hallway, room1, room2, room3, room4, dhall};

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
		} else if (myState == States.solitary_1) {
			state_solitary_1 ();
		} else if (myState == States.desk) {
			state_desk ();
		} else if (myState == States.hallway) {
			state_hallway ();
		} else if (myState == States.room1) {
			state_room1 ();
		} else if (myState == States.room2) {
			state_room2 ();
		} else if (myState == States.room3) {
			state_room3 ();
		} else if (myState == States.room4) {
			state_room4 ();
		} else if (myState == States.dhall) {
			state_dhall ();
		} 
	}
		void state_asylum_1 () {
			text.text = "You stumble into the Asylum. Once you dust yourself off you take a look around." +
				"Everything looks... dead. This wasn't the place you visited your parents. I mean, it was, but you " +
				"notice the drastic changes. \n\n" +
			"Press Space to continue";

			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.asylum_2;
				}
			}

		void state_asylum_2 () {
				text.text = "Press D to check the Desk\n" +
				"Press H to travel down the Hallway\n" +
				"Press S to check Solitary confinment";
			if (Input.GetKeyDown(KeyCode.S)) {
					myState = States.solitary_1;
			} else if (Input.GetKeyDown(KeyCode.D)) {
					myState = States.desk;
			} else if (Input.GetKeyDown(KeyCode.H)) {
					myState = States.hallway;
				}
		}
	
		void state_solitary_1 () {
		text.text = "You walk up to the Solitary Confinement Door. Last you hear your parents were locked " +
		"up here in the their final days.\n" +
		"You try fiddling with the electric keypad\n" +
		"It's non-responsive. There must be a way to get this working...\n\n" +
		"Press R to Return";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.asylum_2;
				}
			}

		void state_hallway () {
		text.text = "Press A to check out Room 1 \n" +
		"Press B to check out Room 2 \n" +
		"Press C to check out Room 3 \n" +
		"Press D to check out Room 4 \n" +
		"Press E to check out the Dining Hall \n\n" +
		"Press R to return";
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.room1;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.room2;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.room3;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.room4;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.dhall;
		} if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_2;
		}
			}
		void state_desk () {
			text.text = "The Desk\n\n" +
			"Press R to return";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.asylum_2;
			}
		}

	void state_room1 () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
		}
	}

	void state_room2 () {
		text.text = "It's locked.\n\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
		}
	}

	void state_room3 () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
		}
	}

	void state_room4 () {
		text.text = "You enter the room\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
		}
	}

	void state_dhall () {
		text.text = "Welcome to dining hall\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
			}
		}
	}