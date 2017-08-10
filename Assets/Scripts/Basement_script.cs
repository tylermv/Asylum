	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Basement_script : MonoBehaviour {
	public Text text;
	public int psychValue;
	StateController stateController;

	private States myState;
	private enum States {basementScene, basementScene2, basement, powerRoom,
	boilerRoom, 
	workShop, workBench, workShelves,
		morgue, bodyDrawers, morgueDesk, bodyDrawers2, bodyDrawers3, bodyDrawers4, bodyDrawersFail,}


	// Use this for initialization
	void Start () {
		myState = States.basementScene;
		stateController = (StateController)FindObjectOfType(typeof(StateController));
		psychValue = stateController.psychCounter;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.basementScene) {
			state_basementScene ();
		} else if (myState == States.basementScene2) {
			state_basementScene2 ();
		} else if (myState == States.basement) {
			state_basement ();
		} else if (myState == States.powerRoom) {
			state_powerRoom ();
		} else if (myState == States.workShop) {
			state_workShop ();
		} else if (myState == States.morgue) {
			state_morgue ();
		} else if (myState == States.boilerRoom) {
			state_boilerRoom ();
		} else if (myState == States.workBench) {
			state_workBench ();
		} else if (myState == States.workShelves) {
			state_workShelves ();
		} else if (myState == States.bodyDrawers) {
			state_bodyDrawers ();
		} else if (myState == States.morgueDesk) {
			state_morgueDesk ();
		} else if (myState == States.bodyDrawers2) {
			state_bodyDrawers2 ();
		} else if (myState == States.bodyDrawers3) {
			state_bodyDrawers3 ();
		} else if (myState == States.bodyDrawers4) {
			state_bodyDrawers4 ();
		} else if (myState == States.bodyDrawersFail) {
			state_bodyDrawersFail ();
		}
	}

	void state_basementScene () {
		text.text = "You venture down into the dark basement\n\n" +
			"You flick on the flashlight. Everything looks damp, untouched and abandoned.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.powerRoom;
		}
	}

	void state_basementScene2 () {
		text.text = "";
	}

	void state_basement() {
		text.text = "You take a look around the basement\n\n" +
			"To your left is a door that has a high voltage sign on it. That must be where you turn the power on." +
			"Beside that is a room that you can't quite make out, but the door is open. To your right, it appears to be the boiler room." +
			"Beside that is another room that looks to have a work bench inside of it.\n" +
			"What do you do?\n\n" +
			"Press P to enter the Power Room\n" +
			"Press B to enter the Boiler Room\n" +
			"Press W to enter the Work Shop\n" +
			"Press M to walk through the open door";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.powerRoom;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boilerRoom;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.workShop;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.morgue;
		}
	}

	void state_powerRoomScene () {
		text.text = "You enter the power room.\n\n" +
		"It's a small room, barely enough room to move around in. But on the wall is 10 levers that look to control the power." +
		"What do you do?\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.powerRoom;
		}
	}

	void state_powerRoom () {
		text.text = 
			"Press A to pull the first lever\n" +
			"Press B to pull the second lever\n" +
			"Press C to pull the third lever\n" +
			"Press D to pull the fourth lever\n" +
			"Press E to pull the fifth lever\n" +
			"Press F to pull the sixth lever\n" +
			"Press G to pull the seventh lever\n" +
			"Press H to pull the eigth lever\n" +
			"Press I to pull the ninth lever\n" +
			"Press J to pull the tenth lever\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.powerRoom;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boilerRoom;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.workShop;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.morgue;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.boilerRoom;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.workShop;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.morgue;
		} else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.boilerRoom;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.workShop;
		} else if (Input.GetKeyDown (KeyCode.J)) {
			myState = States.morgue;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue;
		}
	}

	void state_workShop () {
		text.text = "You enter the workshop.\n" +
			"";
	}

	void state_workBench () {
		
	}

	void state_workShelves () {
		
	}

	void state_morgue () {							//-------------------------------Interesting story point on the desk, find a burnable thing in the drawers------------------//
		text.text = "You walk into what looks like... the morgue.\n\n" +
			"In front of you is a silver desk with a bunch of papers on it and a cofee mug. To your left are what look like to be the body drawers.\n\n" +
			"Press B to check the body drawers\n" +
			"Press D to check the desk\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bodyDrawers;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.morgueDesk;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement;
		}
	}

	void state_bodyDrawers () {
		text.text = "You walk up to the drawers.\n\n" +
			"There are 4 of them, each numbered 1 through 4.\n\n" +
			"What do you do?\n\n" +
			"Press A to open drawer 1\n" +
			"Press B to open drawer 2\n" +
			"Press C to open drawer 3\n" +
			"Press D to open drawer 4\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.bodyDrawersFail;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bodyDrawers2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.bodyDrawersFail;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.bodyDrawersFail;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue;
		}
	}

	void state_bodyDrawers2 () {
		text.text = "";
	}

	void state_bodyDrawers3() {
		text.text = "";
	}

	void state_bodyDrawers4 () {
		text.text = "";
	}

	void state_bodyDrawersFail () {
		text.text = "";
	}

	void state_morgueDesk () {
		text.text = "You walk up to the desk.\n\n" +
			"";
	}

	void state_boilerRoom () {						//-------------This will be used to burn someone to reveal a code--------------//
		text.text = "You walk into the boiler room.\n\n" +
			"It's loud in here, you can barely think to yourself let alone hear whats going on around you." +
			"You can feel the heat from the old furnace. It looks like someone has been keeping this thing on\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement;
		}
	}
}