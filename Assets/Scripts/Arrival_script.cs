using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Arrival_script : MonoBehaviour {

	public Text text;
	public int psychValue = 0;
	public StateController stateController;
	private States myState;
	private enum States { arrival_1, arrival_2, arrival_3, arrival_4, arrival_5, 
		decisions, firstDecision, secondDecision, thirdDecision, doorDecisions, itemOne, 
		door, knock, windows, open_window, car, carDrivers, carTrunk, gloveBox, gloveBoxOpen, 
		building, shed, shed2, building_scene};




	// Use this for initialization
	void Start () {
		myState = States.arrival_1;
		GameObject stateController = GameObject.Find("StateController");
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
		} else if (myState == States.car) {
			state_car ();
		} else if (myState == States.windows) {
			state_windows ();
		} else if (myState == States.building) {
			state_building ();
		} else if (myState == States.shed) {
			state_shed ();
		} else if (myState == States.arrival_3) {
			state_arrival_3 ();
		} else if (myState == States.arrival_4) {
			state_arrival_4 ();
		} else if (myState == States.decisions) {
			state_decisions ();
		} else if (myState == States.arrival_5) {
			state_arrival_5 ();
		} else if (myState == States.open_window) {
			state_open_window ();
		} else if (myState == States.building_scene) {
			state_building_scene ();
		} else if (myState == States.doorDecisions) {
			state_doorDecisions ();
		} else if (myState == States.carDrivers) {
			state_carDrivers ();
		} else if (myState == States.carTrunk) {
			state_carTrunk ();
		} else if (myState == States.gloveBox) {
			state_gloveBox ();
		} else if (myState == States.shed2) {
			state_shed2 ();
		} else if (myState == States.firstDecision) {
			state_firstDecision ();
		} else if (myState == States.secondDecision) {
			state_secondDecision ();
		} else if (myState == States.thirdDecision) {
			state_thirdDecision ();
		} else if (myState == States.gloveBoxOpen) {
			state_gloveBoxOpen ();
		} else if (myState == States.itemOne) {
			state_itemOne ();
		} 
	} 
	//Call the different states in the scene
			void state_arrival_1(){
				text.text = "You're driving.\n\n" +
			"The headllights of on-coming traffic blind you as quickly as they fade away into the night\n\n"+
			"You don’t remember leaving your house or getting into the car. Your head feels fuzzy. " +
			"All you know is that you need answers.\n\n"+
				"Press Space Bar to continue";

				if (Input.GetKeyDown(KeyCode.Space)) {
					myState = States.arrival_2;
				}
			}

	void state_arrival_2 () {
		text.text = "You pull off the highway onto a gravel road.\n\n" +
			"You can see the Asylum in the distance. You remember the day your parents were committed.\n\n" +
			"You think about the word committed. Committed a crime, committed to the Asylum, committed suicide.\n\n"+
			"You try not to get angry. You need to keep a clear head\n\n"+
				"Press Space Bar to continue";
				if (Input.GetKeyDown (KeyCode.Space)) {
					myState = States.arrival_3;
				}
			}

			void state_arrival_3() {
		text.text = "You pull up to the building and turn off the car.\n\n" +
		"You take a breath, close your eyes and grip the steering wheel.\n\n" +
		"The silence inside the car makes you uneasy.\n\n" +
		"Press S to step out of the car";
		
		if (Input.GetKeyUp (KeyCode.S)) {
				myState = States.arrival_4;
		}
	}

			void state_arrival_4 () {
		text.text = "You step out of the car. \n\nYou can hear the distant groans of passing cars down by the highway. " +
		"They're accompanied by the hiss of leaf-lined tree tops swaying in the wind.\n\n" +
		"You look up at the door to the Asylum.\n\n" +
		"Press W to start walking up to the Asylum";

		if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.arrival_5;
			}
		}

	void state_arrival_5 () {
		text.text = "You begin walking up to the Asylum.\n\n" +
		"The gravel crunches underneath your feet with every step. As you look up to the dimly-lit asylum door, you wonder what you're going to say to the people at front desk when you walk in.\n\n" +
		"You wonder if Clarissa is working. She might be a bit easier to convince..." +
		"What will you say?\n\n" +
		"Press Space to contimnue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.decisions;
		}
	}

	void state_decisions () {
		text.text = "What will you say?\n\n" + 
		"Press A for:You’ll force your way in if you have to. You don’t care about anyone and anything other than finding answers.\n\n" +
		"Press B for:You're confident you can turn on the charm and lie to them, convincing them to let you look around\n\n" +
		"Press C for:You’ll tell them the truth. You’re confident they’ll empathize and help you.";
		if (Input.GetKeyDown(KeyCode.A)) {
			stateController.decisionOne = "force";
			myState = States.firstDecision;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			stateController.decisionOne = "lie";
			myState = States.firstDecision;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			stateController.decisionOne = "truth";
			myState = States.firstDecision;
		}
	}

	void state_firstDecision () {
		if (stateController.decisionOne == "force") {
			stateController.AddPsychCounter (psychValue = 5);
			text.text = "You’ll force your way in if you have to. " +
			"You don’t care about anyone and anything other than finding answers. \n\n" +
			"Press Space to continue";
		} else if (stateController.decisionOne == "lie") {
			stateController.AddPsychCounter (psychValue = 3);
			text.text = "You're confident you can turn on the charm and lie to them. Convince them to let you look around.\n\n" +
			"Press Space to continue";
		} else if (stateController.decisionOne == "truth") {
			text.text = "You’ll tell them the truth. You’re confident they’ll empathize and help you\n\n" +
				"Press Space to continue";
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.doorDecisions;
		}
	}

	void state_doorDecisions () {
		if (stateController.itemOne == "hammer") {
			text.text = "You walk up to the door.\n\n" +
			"If that patient is up in her room, there must still be orderly around.\n\n" +
			"You gaze down at the hammer you're holding and then up at the door.\n\n" +
			"What do you do?\n\n" +
			"Press B to break the lock in with the hammer\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.B)) {
				stateController.decisionFour = "doorSmash";
				myState = States.thirdDecision;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.door;
			}
		} else if (stateController.itemTwo == "keyPass") {
			text.text = "You walk up to the door.\n\n" +
				"If that patient is up in her room, there must still be orderly around.\n\n" +
				"You clutch the visitors pass around your neck.\n\n" +
				"What do you do?\n\n" +
				"Press V to use the visitors pass\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.V)) {
				stateController.decisionFour = "keySwipe";
				myState = States.thirdDecision;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.door;
			}	
		}

		else {
		text.text = "You look up at the Asylum door.\n\n" +
			"There are no lights on inside but the outside light remains on. That's odd.\n" +
			"A green blinking light catches your attention. A keycard could get you through the door, but where did you put that thing..\n\n " +
			"What do you do?\n\n"+
			"Press H to to try the door handle\n" +
			"Press F to kick the door in\n" +
			"Press K to knock on the door\n";
		if (Input.GetKeyDown(KeyCode.H)) {
				stateController.decisionTwo = "handle";
			myState = States.secondDecision;
		} else if (Input.GetKeyDown(KeyCode.F)) {
				stateController.decisionTwo = "kick";
			myState = States.secondDecision;
		} else if (Input.GetKeyDown(KeyCode.K)) {
				stateController.decisionTwo = "knock";
			myState = States.secondDecision;
			}
		}
	}

	void state_secondDecision () {
		if (stateController.decisionTwo == "handle") {
			text.text = "You put your hand on the door handle and try to open the door.\n\n" +
			"It's locked. That's strange...\n\n" +
			"Press Space to continue";
		} else if (stateController.decisionTwo == "kick") {
			stateController.AddPsychCounter (psychValue + 5);
			text.text = "You take step back from the door.\n\n" +
			"You start off at a run and kick at the doopr with everything you have.\n\n" +
			"You give out muffled yelp. That hurt.\n" +
			"The door didn't budge\n\n" +
			"Press Space to continue";
		} else if (stateController.decisionTwo == "knock") {
			text.text = "You knock on the door in hopes that someone answers." +
				"You've never seen this place locked before, let alone with no lights on inside." +
				"You listen intently...\n\n" +
				"Silence.\n\n" +
				"You knock again... nothing. You press your ear up to the door and listen for footsteps or voices or anything.\n\n" +
				"You hear something faint... What is that? Is that someone breathing?\n\n" +
				"Press Space to continue";
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.door;
		}
	}

	void state_door () {
		if (stateController.itemOne == "hammer") {
			text.text = "You make it back to the front of the Asylum with hammer in hand.\n" +
			"What do you do?\n\n" +
			"Press D to try the front door\n" +
			"Press C to check your car\n" +
			"Press W to investigate the windows";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.doorDecisions;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.car;
			} else if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.windows;
			}
		} else if (stateController.itemOne == "wire") {
			text.text = "You make it back to the front of the Asylum with the copper wire in hand.\n" +
			"What do you do?\n\n" +
			"Press D to try the front door\n" +
			"Press C to check your car\n" +
			"Press W to investigate the windows";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.doorDecisions;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.car;
			} else if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.windows;
			}
		} else if (stateController.itemOne == "bentWire") {
			text.text = "You make it back to the front of the Asylum with the copper wire in hand.\n" +
				"What do you do?\n\n" +
				"Press D to try the front door\n" +
				"Press C to check your car\n" +
				"Press W to investigate the windows";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.doorDecisions;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.car;
			} else if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.windows;
			}
		} else {
			text.text = "You take a look around.\n\n" +
			"To your right you see some Windows. You could try there. " +
			"It also might be worth taking a look around the building. " +
			"You glance back at your car. You could have something useful in there.\n\n" +
			"Press W to check the windows\n" +
			"Press B to take a look around the building\n" +
			"Press C to check out the car\n" +
			"Press D to try the door again";
			if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.windows;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.building;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.car;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.doorDecisions;
			}
		}
	}
		
	void state_car () {
		text.text = "You walk back to the front of your car.\n\n" +
			"Your Dad gave you this car. It's old yes, but you have so many memories in this car. And hey, it happens to be your favourite shade of blue. \n\n" +
		"What do you do?\n\n" +
		"Press D to open the car door\n" +
		"Press T to open the trunk\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.carDrivers;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.carTrunk;
		}
	}

	void state_carDrivers () { 
		text.text= "You open the door to your car.\n\n" +
			"There's some fast food wrappers on the floor and a blanket in the back. Doesn't look like there's" +
			" much that can help here.\n\n" +
			"Press G to open the glove box\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.gloveBox;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door;
		}
	}

	void state_gloveBox () {
		if (stateController.itemTwo == "keyPass") {
			text.text = "There's not much left in there but some old napkins and a magazine\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.car;
			}
		} else if (stateController.itemOne == "wire") {
			text.text = "You try opening the glove box.\n" +
			"It won't budge.\n" +
			"That thing has been stuck for as long as you can remember.\n\n" +
			"Press P to try and pick the lock\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.P)) {
				myState = States.gloveBoxOpen;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.car;
			}
		} else if (stateController.itemOne == "hammer") {
			text.text = "You try opening the glove box.\n" +
			"It won't budge.\n" +
			"That thing has been stuck for as long as you can remember.\n\n" +
			"Press S to smash it open\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.S)) {
				stateController.decisionThree = "smash";
				myState = States.gloveBoxOpen;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.car;
			} 
		} else {
			text.text = "You try opening the glove box.\n\n" +
				"It won't budge.\n" +
				"That thing has been stuck for as long as you can remember. If only there was a way to pick the latch keeping it closed.\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.car;
				}
			}
		}

	void state_gloveBoxOpen () {
		if (stateController.decisionThree == "smash") {
			stateController.AddPsychCounter (psychValue + 3);
			text.text = "You lift up your hammer\n\n" +
				"With a crack you smash into the lock of the glove box. Swipe after swipe you smash into it.\n" +
				"It doesn't budge.\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.car;
			}
		} else {
			stateController.itemOne = "bentWire";
			stateController.itemTwo = "keyPass";
			text.text = "You open the glove box\n\n" +
			"Inside you find your old visitors pass. Maybe this can help.\n\n" +
			"You look at the copper wire. It looks mangled. No more picking locks with this thing.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.car;
			}
		}
	}

	void state_carTrunk () { 				//this should be psych controlled
		text.text= "You open the trunk of your car." +
			" There's a car jack and a spare tire. Beside that is your gym bag with some old clothes.\n\n" +
			"There's nothing of use here.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.car;
		}
	}
		

	void state_windows () {
		if (stateController.itemOne == "wire") {
			text.text = "You walk up top the windows and look inside.\n\n" +
			"It's dark. You can't see much inside.\n\n" +
			"You can make out a dim light off into the distance. The light flickers. Looks like someone is inside." +
			"You look down at the copper wire in your hand\n\n" +
			"Press P to try and pull the latch open\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.P)) {
				stateController.decisionFour = "latch";
				myState = States.thirdDecision;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.door;
			}
		} else if  (stateController.itemOne == "hammer") {
			text.text = "You walk up top the windows and look inside.\n\n" +
				"It's dark. You can't see much inside.\n\n" +
				"You can make out a dim light off into the distance. The light flickers. Looks like someone is inside." +
				"You look down at the hammer in your hand\n\n" +
				"Press S to smash the window\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.S)) {
				stateController.decisionFour = "smash";
				myState = States.thirdDecision;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.door;
			}
		} else if (stateController.itemOne == "bentWire") {
			text.text = "You walk up top the windows and look inside.\n\n" +
				"It's dark. You can't see much inside.\n\n" +
				"You can make out a dim light off into the distance. The light flickers. Looks like someone is inside." +
				"You look down at the copper wire in your hand\n" +
				"It looks too mangled to use.\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.P)) {
				stateController.decisionFour = "latch";
				myState = States.thirdDecision;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.door;
			}
		} else {
		text.text = "You walk up to the windows and look inside.\n\n" +
			"It’s dark. You can't see much inside.\n\n" +
			"You can make out a dim light off in the distance. The light flickers. " +
			"Looks like someone is inside.\n\n" +
			"Press O to try Opening the window\n" +
			"Press R to return to the front";
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.open_window;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door;
		}
	}
}
		
	void state_open_window () {
			text.text = "You try opening the window\n\n" +
		"It doesn't budge. You can see the latch that's keeping it closed through the window\n\n" +
		"Press R to return to the front";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door;
			}
		}

	void state_building () {
		text.text = "You walk past the window and your car.\n\n" +
			"You used to take walks around the building with your Mom. She loved being outside in the fresh air. She used to hold your arm while you talked about your future and your dreams.\n\n" +
			"It’s hard to see anything with so little light outside, but the moonlight gives you enough vision to make out the shed.\n\n" +

			"Press S to investigate the Shed\n" +
			"Press R to return to the front";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.shed;
		}
	}

	void state_shed () {
		if (stateController.psychCounter >= 5) {
			text.text = "You walk up to the shed.\n\n" +
			"It's looks old and rusty. You've seen it before when you used to visit your parents. You don't remember it looking this run down.\n\n" +
			"Press O to open the shed"; 
		} else if (stateController.psychCounter <= 4) {
			text.text = "You walk up to the shed.\n\n" +
				"In the little light you have you can see the shed hasn't changed much. It's a beautiful pink shed with white trim and details." +
				"It's looks like a fairty tale house against the tree-line.\n\n" +
				"Press O to open the shed";
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.shed2;
		} 
	}

	void state_shed2 () { 	
		text.text = "You open the doors to the shed.\n\n" +
			"A cloud of dust greets you as you walk in. It semlls... musty.\n\n" +
			"You feel around in the darkness for anything that might help. You touch what feels like a garden hose, and then a watering can. With the little light you have" +
			" you make it over to a work bench. There you find a carpenters hammer and some copper wire.\n\n" +
			"Press W to grab the wire.\n" +
			"Press H to grab the hammer.";
		if (Input.GetKeyDown (KeyCode.W)) {
			stateController.itemOne = "wire";
			myState = States.itemOne;
		} else if (Input.GetKeyDown (KeyCode.H)) {
			stateController.itemOne = "hammer";
			myState = States.itemOne;
		}
	}

	void state_itemOne () {
		if (stateController.itemOne == "wire") {
			text.text = "You grab the copper wire.\n\n" +
				"The feel of the copper wire reminds you of your Mom. She used to use wire like this as part of her arts and crafts\n\n" +
				"Press Space to continue back";
		} else if (stateController.itemOne == "hammer") {
			text.text = "You pick up the hammer.\n\n" +
				"The feel of the hammer reminds you of your Dad. He was a carpenter by trade and always loved working with his hands.\n\n"+
				"Press Space to continue back";
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.building_scene;
		}
	}

	void state_building_scene () {
		text.text = "You begin walking back to the front of the Asylum.\n\n" +
		"Something in one of the windows catches the corner of your eye." +
		"You look up to see the grim face of a woman staring down at you. Her eyes are fixated on you, never blinking. " +
		"She must be a patient you think to yourself. She looks familiar. You must have seen her before when visiting you parents here.\n\n" +
		"You try not to pay attention but as you walk back to the front of the building her gaze follows you.\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.door;
		}
	}
		
	void state_thirdDecision () {
		if (stateController.decisionFour == "smash") {
			stateController.AddPsychCounter (psychValue + 5);
			text.text = "You lift the hammer into the air. With swiftness and stregnth you slam your hammer through the glass.\n\n" +
			"The smash echoes off the inner walls of the Asylum and into the night. " +
			"You stop for a moment and listen intently...\n\n" +
			"Silence.\n\n" +
			"What the hell is going on? Someone should have heard that.\n\n" +
			"Press Space to Enter the Asylum";
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		} else if (stateController.decisionFour == "keySwipe") {
			text.text = "You swipe your visitors pass.\n\n" +
			"There's quick beep and after a moment, a click. The door slowly creeks open.\n\n" +
			"Press Space to enter the asylum";
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		} else if (stateController.decisionFour == "doorSmash") {
			stateController.AddPsychCounter (psychValue + 5);
			text.text = "You smash the hammer into the lock.\n\n" +
			"You smash and smash, looking for any give.\n\n" +
			"The door doesn't budge.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.door;
			}
		} else if (stateController.decisionFour == "latch") {
			text.text = "You fashion the wire into a hook.\n\n" +
				"You press the wire into the bottom of the window. You can see the end of it appear on the other.\n" +
				"After a couple of twists and turns you pull the latch and open the window.\n\n" +
				"Press Space to enter the asylum";
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		}
	}
}