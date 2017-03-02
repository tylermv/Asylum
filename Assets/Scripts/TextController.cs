using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {


	public Text text;

	private States myState;
	private enum States {arrival_1, arrival_2, door};


	// Use this for initialization
	void Start () {
		myState = States.arrival_1;

	}

	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.arrival_1) {
			state_arrival_1 ();
		} else if (myState == States.arrival_2) {
			state_arrival_2 ();
		} else if (myState == States.door) {
			state_door ();
		}

	} 
	void state_arrival_1(){
		text.text = "You open the gates to The Asylum.\n\n" +
		"Here your parents were committed. You think about how committed is a funny word. " +
		"Committed a crime. Committed to the institute. Committed suicide...\n\n\n" +
		"Press Space Bar to continue";

		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.arrival_2;
		}
	}

	void state_arrival_2 () {
		text.text = "As the car pulls up to the building you think about what " +
		"you're going to say to the administrator at the front desk or the " +
		"nurses through out the institution.\n\n\n" +
		"Press Space Bar to continue";

		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.door;
		}
	}

		void state_door() {
			text.text = "You park your car and you walk up the steps to the front door." +
				"You're about to knock on the door when you're stricken by fear." +
				"You don't know what you'll do once you get in, but you have to clear your name. What do you do?\n\n" +
				"To Knock on the door press K\n" +
				"To Walk into the Asylum press W";
		}
	}

