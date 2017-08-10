using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Asylum_script : MonoBehaviour {
	//editing notes, last stopped after escaping the psych room. Still haven't edited the normal escape.
	public Text text;
	public int psychValue;
	StateController stateController;

	public States myState;
	public enum States {asylum_1, asylum_2, asylum_3, asylum_4, fifthDecision, seduce, charm, ask, asylum_5, asylum_front, medical_doors, 
		medical_doors_2, deskScene, desk, hallway, hallwayScene, drawers, map, computer, flashLight, asylum_candle, 
		medical_doors_candle, medical_doors_candle_2,
		basement_door, room1, room2, room2Scene, dhall, room1_escape, psych_escape, room1_bed, room1_mirror, room1_door,
		room1_mirror_take, room1_code, code_solve, code_solve_null, code_solve_true, code_solve_true_2,
		code_solve_true_3, code_solve_true_4, code_solved, psych1_vanity, psych1_door, psych1_bed, psych1_door2, psych1_robe, psych_escape2,
	psych_escape3, psych_drawers, psych_mirror_pickup, psych2_vanity, psych2_drawers, psych2_door, psych2_robe, psych2_lock,
		psych_code1, psych_transition, psych_code_null1, psych_code_scene, psych_escape_4, psych3_bed, psych_code2, psych_code3, psych_code_null,
		psych_solved, psych_code4, escaped, escaped_2, escaped_hallway, escaped_room1, escaped_room2, escaped_basement_door, escaped_dhall, 
		escaped_asylum, escaped_desk, escaped_medical_doors, escaped_medical_doors_2, escaped_map, escaped_drawers, escaped_computer, 
		psych_escaped, psych_escaped_2, room1_note}; 

	// Use this for initialization
	void Start () {
		myState = States.asylum_1;
		stateController = (StateController)FindObjectOfType(typeof(StateController));
		psychValue = stateController.psychCounter;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.asylum_1) {
			state_asylum_1 ();
		} else if (myState == States.asylum_2) {
			state_asylum_2 ();
		} else if (myState == States.asylum_3) {
			state_asylum_3 ();
		} else if (myState == States.fifthDecision) {
			state_fifthDecision ();
		} else if (myState == States.asylum_4) {
			state_asylum_4 ();
		} else if (myState == States.asylum_front) {
			state_asylum_front ();
		} else if (myState == States.medical_doors) {
			state_medical_doors ();
		} else if (myState == States.medical_doors_2) {
			state_medical_doors_2 ();
		} else if (myState == States.deskScene) {
			state_deskScene ();
		} else if (myState == States.desk) {
			state_desk ();
		} else if (myState == States.map) {
			state_map ();
		} else if (myState == States.computer) {
			state_computer ();
		} else if (myState == States.drawers) {
			state_drawers ();
		} else if (myState == States.flashLight) {
			state_flashLight ();
		} else if (myState == States.hallway) {
			state_hallway ();
		} else if (myState == States.hallwayScene) {
			state_hallwayScene ();
		} else if (myState == States.room1) {
			state_room1 ();
		} else if (myState == States.room2) {
			state_room2 ();
		} else if (myState == States.dhall) {
			state_dhall ();
		} else if (myState == States.basement_door) {
			state_basement_door ();
		} else if (myState == States.psych_escape) {
			state_psych_escape ();
		} else if (myState == States.room1_escape) {
			state_room1_escape ();
		} else if (myState == States.room1_mirror) {
			state_room1_mirror ();
		} else if (myState == States.room1_bed) {
			state_room1_bed ();
		} else if (myState == States.room1_door) {
			state_room1_door ();
		} else if (myState == States.room1_mirror_take) {
			state_room1_mirror_take ();
		} else if (myState == States.room1_code) {
			state_room1_code ();
		} else if (myState == States.code_solve) {
			state_code_solve ();
		} else if (myState == States.code_solve_null) {
			state_code_solve_null ();
		} else if (myState == States.code_solve_true) {
			state_code_solve_true ();
		} else if (myState == States.code_solve_true_2) {
			state_code_solve_true_2 ();
		} else if (myState == States.code_solve_true_3) {
			state_code_solve_true_3 ();
		} else if (myState == States.code_solve_true_3) {
			state_code_solve_true_3 ();
		} else if (myState == States.psych1_bed) {
			state_psych1_bed ();
		} else if (myState == States.psych1_vanity) {
			state_psych1_vanity ();
		} else if (myState == States.psych1_door) {
			state_psych1_door ();
		} else if (myState == States.psych1_door2) {
			state_psych1_door2 ();
		} else if (myState == States.psych1_robe) {
			state_psych1_robe ();
		} else if (myState == States.psych_escape2) {
			state_psych_escape2 ();
		} else if (myState == States.psych_mirror_pickup) {
			state_psych_mirror_pickup ();
		} else if (myState == States.psych_drawers) {
			state_psych_drawers ();
		} else if (myState == States.psych2_robe) {
			state_psych2_robe ();
		} else if (myState == States.psych2_lock) {
			state_psych2_lock ();
		} else if (myState == States.psych_code1) {
			state_psych_code1 ();
		} else if (myState == States.psych_code_null1) {
			state_psych_code_null1 ();
		} else if (myState == States.psych3_bed) {
			state_psych3_bed ();
		} else if (myState == States.psych_code4) {
			state_psych_code4 ();
		} else if (myState == States.psych_code3) {
			state_psych_code3 ();
		} else if (myState == States.psych_code2) {
			state_psych_code2 ();
		} else if (myState == States.psych_code_scene) {
			state_psych_code_scene ();
		} else if (myState == States.psych_transition) {
			state_psych_transition ();
		} else if (myState == States.psych_code_null) {
			state_psych_code_null ();
		} else if (myState == States.psych_escape_4) {
			state_psych_escape_4 ();
		} else if (myState == States.escaped) {
			state_escaped ();
		} else if (myState == States.escaped_2) {
			state_escaped_2 ();
		} else if (myState == States.escaped_room2) {
			state_escaped_room2 ();
		} else if (myState == States.escaped_basement_door) {
			state_escaped_basement_door ();
		} else if (myState == States.escaped_dhall) {
			state_escaped_dhall ();
		} else if (myState == States.escaped_asylum) {
			state_escaped_asylum ();
		} else if (myState == States.escaped_medical_doors) {
			state_escaped_medical_doors ();
		} else if (myState == States.escaped_desk) {
			state_escaped_desk ();
		} else if (myState == States.escaped_medical_doors_2) {
			state_escaped_medical_doors_2 ();
		} else if (myState == States.escaped_map) {
			state_escaped_map ();
		} else if (myState == States.escaped_drawers) {
			state_escaped_drawers ();
		} else if (myState == States.escaped_computer) {
			state_escaped_computer ();
		} else if (myState == States.escaped_hallway) {
			state_escaped_hallway ();
		} else if (myState == States.psych_escaped) {
			state_psych_escaped ();
		} else if (myState == States.psych_escaped_2) {
			state_psych_escaped_2 ();
		} else if(myState == States.room2Scene) {
			state_room2Scene ();
		} else if(myState == States.room1_note) {
			state_room1_note ();
		}
	}
		void state_asylum_1 () {
		if (stateController.decisionFour == "keySwipe") {
			text.text = "You walk into the Asylum.\n\n" +
			"Memories flow back to when you used to visit your parents here. It's dark except for the flickering of a flashlight on a desk at the back of the room.\n\n" +
			"Despite the limited light you find yourself in a familiar spot. The waiting room.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.asylum_2;
			}
		} else {
			text.text = "You stumble into the Asylum. \n\n" +
			"You dust yourself off and take a look around. It's dark except for the flickering of a flashlight on a desk at the back of the room.\n\n" +
			"Despite the limited light you find yourself in a familiar spot. The waiting room.\n\n" +
			"Press Space to continue";

			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.asylum_2;
			}
		}
	}

		void state_asylum_2 () {
		text.text = "You remember spending a lot of time here waiting for your parents when you'd come to visit. " +
		"You were always waiting it seemed, and you got to see them so little.\n\n" +
		"Clarissa worked the front desk. You two would laugh just talking about your dating lives and plans for the future.\n\n" +
		"You wonder what you might say to Clarissa if she were here in this room right now.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown(KeyCode.Space)) {
					myState = States.asylum_3;
			} 
		}

	void state_asylum_3 () { 
		text.text = "Press A for You'd turn on the charm and ask Clarissa on a date.\n\n" +
			"Press B for You'd attempt to seduce her. You've always been so attracted to Clarissa.\n\n" +
			"Press C for You'd ask about her dating life. You remember that wasn't going so well.";
		if (Input.GetKeyDown (KeyCode.A)) {
			stateController.decisionFive = "charm";
			myState = States.fifthDecision;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			stateController.decisionFive = "seduce";
			myState = States.fifthDecision;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			stateController.decisionFive = "ask";
			myState = States.fifthDecision;
		}
	}

	void state_fifthDecision () {
		if (stateController.decisionFive == "charm") {
			stateController.AddPsychCounter (psychValue + 3);
			text.text = "You picture it in your head.\n\nYou'd walk up to the desk and make a comment about " +
			"her earrings or her dress. You'd tell her she looks amazing in whatever colour she's wearing.\n\n" +
			"You'd ask her what she might be thinking for dinner that night.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.asylum_4;
			}
		} else if (stateController.decisionFive == "seduce") {
			stateController.AddPsychCounter (psychValue + 5);
			text.text = "You'd walk up to the desk and knock over the pens and pencils she kept nearby.\n\n" +
			"So sorry! You would say as you bent down to help her. You'd toucher her hand and meet her eyes as you both stood...\n\n" +
			"Press Space to continue";

			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.asylum_4;
			}
		} else if (stateController.decisionFive == "ask") {
			text.text = "You haven't seen Clarissa in quite some time... since the incident anyways. " +
				"You know she was having dating troubles and always had some hilarious story to tell.\n\n" +
				"You’d probably ask about the guy with greasy hair and well kept mustache.\n\n" +
				"Press Space to continue";

			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.asylum_4;
			}
		}
	}

	void state_asylum_4 () {
		text.text = "A moving shadow suddenly breaks your train of thought.\n\n" +
			"Was that the wind? Was it just the flashlight? Or something else...\n\n" +
			"The slam of a door down the hall startles you. It's definitely not just the wind.\n\n" +
			"You look around the big, empty, dark room and suddenly feel exposed. " +
			"I should keep moving, grab what I came for and get the hell out of here.\n\n"+
			"Press Space to continue";
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.asylum_front;
		}
	}

	void state_asylum_front () {
		if (stateController.itemThree == "flashLight") {
			text.text = "To your right is the long hallway where you heard the banging of a door.\n\n" +
			"To your left you see the medical wing. You shiver at the thought of going in there.\n\n" +
			"Of course, you could always look through Clarissa's desk. There could be answers there.\n\n" +
			"What do you do?\n\n" +
			"Press H to walk down the Hallway\n" +
			"Press M to check out the Medical wing\n" +
			"Press D to check out the Desk.";
			if (Input.GetKeyDown (KeyCode.H)) {
				myState = States.hallwayScene;
			} else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.medical_doors_candle;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.desk;
			}
		} else { 
			text.text = "To your right is the long hallway where you heard the banging of a door.\n\n" +
			"To your left you see the medical wing. You shiver at the thought of going in there.\n\n" +
			"Of course, you could always look through Clarissa's desk. There could be answers there.\n\n" +
			"What do you do?\n\n" +
			"Press H to walk down the Hallway\n" +
			"Press M to check out the Medical wing\n" +
			"Press D to check out the desk.";
			if (Input.GetKeyDown (KeyCode.H)) {
				myState = States.hallway;
			} else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.medical_doors;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.deskScene;
			}
		}
	}

	void state_hallway () {
		if (stateController.itemThree == "flashLight") {
			text.text = "What do you do?\n\n" +
			"Press A to walk into Room 1 \n" +
			"Press B to try opening Room 2 \n" +
			"Press C to investigate the Basement. There may be a way to turn the power on down there.\n" +
			"Press D to check venture into the Dining Hall. That's where the kitchens are. \n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.room1;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.room2;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.basement_door;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.dhall;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.asylum_front;
			}
		} else { 
			text.text = "You stare down the long dark hallway. \n\n" +
			"You heard the sound of someone slamming a door down this way earlier.\n\n" +
			"As you stare into the darkness you can't help but feel like someone is staring back at you. " +
			"It's too dark to venture down the hallway right now.\n\n" +
			"Press R to return";

			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.asylum_front;
			}
		}
	}
		
	void state_hallwayScene () {
		text.text = "You venture down the dark hallway with the flashlight lighting your way.\n\n" +
			"The light reveals four doors down the hallway. There are two that are numbered, Door 1 and Door 2. Door 1 is cracked open while Door 2 is closed shut.\n\n" +
			"You venture down a bit further and you see Basement written on one of the doors and Dining Hall written on the other.\n\n"+
			"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.hallway;
		} 
	}
	
		void state_medical_doors () {
		text.text = "You walk up to the doors of the Medical Wing.\n\n" +
			"Last you heard your parents were locked up here in their final days.\n" +
			"You were told there was nothing that could be done after the incident but you just know something isn't right with their deaths.\n\n" +
			"A part of you knows the answers you need are behind these doors." +
			"You stare at the windows of the doors. Is that... are those scratch marks on the glass?\n\n" +
			"Press Space to conintue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.medical_doors_2;
		} 
	}

	void state_medical_doors_2 () {
		text.text = "You try opening the door.\n\n" +
			"Locked.\n\n" +
			"You look for the lock and notice there's a keypad. You press some numbers but it's not responding." +
		"There must be a way to get this working...\n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_front;
		} 
	}

	void state_deskScene () {
		text.text = "You make your way over to the desk. \n\n" +
			"The floor creeks undereath you with every step you take. " +
		"This place feels alive somewhow. Like it's ready to swallow you up whole at any moment\n\n" +
		"On the desk you see a computer. It looks dusty but it might still work. There's are some guest maps of the Asylum beside the computer. " +
		"Of course you could always rummage through Clarissa's drawers. What do you do?\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.desk;
		}
	}

	void state_desk () {
		if (stateController.itemThree == "flashLight") {
				text.text = "You walk over to the desk.\n\n" +
					"Press C to check the computer. There could be some answers on there.\n" +
					"Press M to check the visitor pamphlets. You remember there was a map on there.\n" +
					"Press D to check the drawers. Maybe Clarissa tucked something away?\n" +
					"Press R to return to the front";
				if (Input.GetKeyDown (KeyCode.R)) {
					myState = States.asylum_front;
				} else if (Input.GetKeyDown (KeyCode.M)) {
					myState = States.map;
				} else if (Input.GetKeyDown (KeyCode.D)) {
					myState = States.drawers;
				} else if (Input.GetKeyDown (KeyCode.C)) {
					myState = States.computer;
				}
		} else {
			text.text = "You walk over to the desk.\n\n" +
				"Press C to check the computer. There could be some answers on there.\n" +
				"Press M to check the visitor pamphlets. You remember there was a map on there.\n" +
			"Press D to check the drawers. Maybe Clarissa tucked something away?\n" +
			"Press F to pickup the flashlight. That will probably come in handy.\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.asylum_front;
			} else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.map;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.drawers;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.computer;
			} else if (Input.GetKeyDown (KeyCode.F)) {
				myState = States.flashLight;
			}
		}
	}

	void state_computer () {
		if (stateController.itemThree == "flashLight") {
			text.text = "You try turning on the computer. There doesn't seem to be any power on in the building..." +
					"With flashlight in hand you gaze into your own reflection into the darkness of the computer screen\n\n" +
					"When did I get so... tired looking? You wonder. To your horror you see something behind you. " +
					"As quick as it's there it leaves in a flash. You're frozen with fear. With eyes wide and your heart racing you wonder. Was that a face, or is" +
					" my mind just playing tricks on me now...\n\n" +
					"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.desk;
				}
		} else { 
			text.text = "You sit down at the desk.\n\n" +
				"You see a computer mouse and give a shake. " +
				"Nothing.\n" +
				"You notice a computer tower under the desk. You press the power button. And then again. " +
				"Nothing.\n\n" +
				"There doesn't seem to be any power.\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.desk;
			}
		}
	}

	void state_drawers () {
		text.text = "You try opening the drawer.\n\n" +
			"It's locked\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.desk;
		}
	}

	void state_map () {
			text.text = "There's a bunch of pamphlets sitting on Clarissa's desk. She would give these " +
			"out to the guests who didn't know there way around.\n\nYou pick one up and scan the map quickly." +
			"You notice there's basement to this place. If there's a way to get the lights on and the power running it's probably down there.\n\n" +
			"The map indiciates there's a door to the basement just down the hall. There's also a door to the basement in the kitchens, just past the dining hall." +
			" The door the dining hall is also just down the hallway. Convenient.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.desk;
			}
		}

	void state_flashLight () {
		stateController.itemThree = "flashLight";
		text.text = "You take a look at the flashlight and then a quick look at your surroundings. This asylum looks abandoned. Where did everyone go?\n\n" +
			"You pick up the flashlight and test it out. It works. \n\n" +
			"The light begins to burn through the darkness that surrounds you.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.desk;
		}
	}


	void state_dhall () {
		text.text = "You walk up to the doors of the dining hall. " +
			"You try pushing them open but they seem to be jammed closed. Are they locked? It doesn't feel like it...\n\n" +
			"It feels like someone is holding the door closed on the other side. But that doesn't make sense...\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
		}
	}

	void state_basement_door () {
		text.text = "You walk over to the basement door. You take a look around and shudder to think " +
			"at what might be downstairs.\n\n" +
			"If there's a way to turn the power on in this place it's probably in the basement." +
			"You press your hand to knob and turn it.\n\n" +
			"It's locked. Figures.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
		}
	}
		
	void state_room2 () {
		text.text = "You walk up to Room 2. You lift your arm to touch the door handle when you suddenly hear voices." +
			"You slowly bring your ear to the door. It sounds like a woman talking." +
			"You listen intently but can only make up faint mumbling\n\n" +
			"What do you do?\n\n" +
			"Press A to knock on the door\n" +
			"Press B to talk to the person\n" +
			"Press C to try and kick the door in";
		if (Input.GetKeyDown (KeyCode.A)) {
			stateController.decisionSix = "knock";
			myState = States.room2Scene;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			stateController.decisionSix = "talk";
			myState = States.room2Scene;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			stateController.decisionSix = "kick";
			myState = States.room2Scene;
		}
	}

	void state_room2Scene () {
		if (stateController.decisionSix == "knock") {
			text.text = "You knock on the door. Knock. Knock. Knock.\n\n" +
			"The woman on the other side keeps talking but just a bit louder. You knock again... knock knock knock.\n" +
			"The woman begins to yell loudy. You can make out only a couple of words.\n" +
			"SHOULD HAVE... COULDNT.. SAVE THEM... She screams in agony.\n\n" +
			"Hello!? HELLO?! You yell in a panic.\n" +
			"Silence.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.hallway; //Will need to change this later on so the player doesn't get back to this state
			}
		} else if (stateController.decisionSix == "talk") {
			text.text = "Hello?! Is anyone there? You ask out loud.\n\n" +
			"The talking suddenly stops. You ask again. " +
			"Hello?! I can hear you in there. I'm looking for someone who works hea...\n\n" +
			"Suddenly there;s a violent banging on the door.\nBANG BANG BANG" +
			"\nIt sounds like the woman is trying to break the door down. You step away slowly and watch the convulsing door in the light. You prepare yourself for what comes next." +
			"As suddenly as it started, the banging stops.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.hallway; //Will need to change this later on so the player doesn't get back to this state
			}
		} else if (stateController.decisionSix == "kick") {
			stateController.psychCounter = + 3;
			text.text = "You came here for answers. You're tired of this cat and mouse game.\n\n" +
				"You begin to kick wildly at the door handle trying to get it to break. You hear the woman on the other side wailing. She sounds scared.\n\n" +
				"You keep kicking the door violently trying to get through.\n\n" +
				"You tire yourself out. The door won't budge.\n\n" +
				"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.hallway; //Will need to change this later on so the player doesn't get back to this state
			}
		}
	}

	void state_room1 () {
		if (stateController.psychCounter >= 25) {
		text.text = "You venture into Room 1. \n\n" +
			"The bed doesn't look like a bed you'd find in an Asylum. It's made of wood, same as the vanity on the opposite side of the room.\n\n" +
			"Just as you lift your flashlight to take a more detailed look at everything, the door behind you slams shut.\n\n" +
			"BANG\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.psych_escape;
			}
				} else {
			text.text= "You venture into Room 1.\n\n" +
				"The walls are dark and decrepid. There's nothing but a bed with a pillow and some sheets and a sink with a mirror above it on the wall.\n\n" +
				"You walk over to the bed and as your hand touches the bed frame, the door behind you slams shut.\n\n" +
				"BANG.\n\n" +
				"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.room1_escape;
			}
		}
	}

	void state_room1_escape () {
		if (stateController.itemFour == "mirror") {
			text.text = "You need to escape. What do you do?\n\n" +
			"Press B to investigate under the Bed\n" +
			"Press D to investigate the Door";
			if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.room1_bed;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.room1_code;
			}
		} else { 
			text.text = "You bang on the door. Hey!\n\n" +
			"No answer. You take a look around you. There are no windows to crawl through, no other doors to open. " +
			"The room looks more like someone's hideout than a patients room. There are some candy wrappers and opened cans of food strewn around the room.\n" +
			"You have to escape. What do you do?\n\n" +
			"Press B to investigate the Bed\n" +
			"Press D to investigate the Door\n" +
			"Press M to investigate the Mirror";
			if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.room1_mirror;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.room1_bed;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.room1_door;
			}
		}
	}

	void state_room1_mirror () {
		text.text = "You walk up to the mirror.\n\n" +
			"It's covered in dust. It hasn't been wiped down in some time. " +
			"You use your sleeve to wipe it clean. As you wipe it off the mirror moves. It's loose. This could come in handy\n\n" +
			"Press M to take the Mirror\n" +
			"Press R to return";
		
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			stateController.itemFour = "mirror";
			myState = States.room1_mirror_take;
		}
	}

	void state_room1_bed () {
		if (stateController.itemFour == "mirror") {
			text.text = "You bend down. You slowly take a look under the bed. \n\nThere's nothing there. \n\nYou glance down at the shards of mirror again and notice" +
				" there's something underneath the bed frame. You roll under the bed to look up. A note?\n\n" +
				"Press N to pickup the note\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.room1_escape;
			} else if (Input.GetKeyDown (KeyCode.N)) {
				myState = States.room1_note;
			}
		} else {
			text.text = "You walk over to the bed. \n\nThe blankets have been thrown onto the floor while the sheets sit on the bed ruffled. The pillow looks like it had been thrown onto the bed as well." +
			"\n\nThere's nothing helpful here.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.room1_escape;
			}
		}
	}

	void state_room1_note () {					
		text.text = "You read the note.\n\n" +
		"To whoever may be imprisoned next, this is Four you. \n\nI fear I'm at the end of my days. No One has found me but I fear Dr. Fulton is getting closer. " +
		"It's been almost Three months stuck in here posing as one of his prisoners. But I must escape Four my survival. " +
		"I can hear him getting closer everyday, becoming more insane as he searches Four the escaped.\n\n" +
		"Signed, Clarissa\n\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		}

	}

	void state_room1_door () {
		text.text = "You walk up to the door with flashlight in hand. \n\nThere's not much to it except you notice there's a " +
			"hatch open in the middle of the door.\n\nYou hold the flashlight up to it but all you see is darkness on the outside. If only you could see what the lock looks like on the outside...\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		}
	}

	void state_room1_mirror_take () {
		text.text = "You put the flashlight down on the sink. You grab the mirror by both sides and attempt to dismantle it from the wall. As you pull on the mirror you catch a sharp edge and cut your hand.\n\n" +
			"You drop the mirror on the floor and it shatters. You hold your bleeding hand and look down at the floor. You bend down to pick up a broken shard. From the reflection of the broken glass, it looks like there's something under the bed...\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.room1_escape;
		}
	}

	void state_room1_code () {
		text.text = "You walk over to the door. You use one hand to hold the mirror outside the door while the flashlight provides light. It looks like the lock requires a 4 digit code. What do you do?\n\n" +
			"Press U to attempt to Unlock the door\n"+ 
			"Press E to keep Exploring the room";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.code_solve;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.room1_escape;
		}
	}

	void state_code_solve () {
		text.text = "The current combination on the lock reads 1 - 1 - 1 - 1. Enter the first number" +
			" or continue searching the room\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.code_solve_null;
		}  else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.code_solve_true;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		}
	}

	void state_code_solve_null () {
		text.text = "You set the number in place. Just as you're about to move onto the next number a hand reaches out from the shadows and grabs your hand violently.\n\n" +
			"You try to get your arm inside but the stregnth of this person is too great.\n\nJust as you imagine the worst, the arm dissapears back into the darkness." +
			"You take a look at the lock. It's been resent.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.code_solve;
		}
	}

	void state_code_solve_true () {
		text.text = "The current combination on the lock reads 4 - 1 - 1 - 1. Enter the second number" +
			" or return to searching the room.\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.code_solve_true_2;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.code_solve_null;
		}  else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		}
	}

	void state_code_solve_true_2 () {
		text.text = "The current cominbation on the lock reads 4 - 1 - 1 - 1. Enter the third number" +
			" or return searching the room.\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.code_solve_true_3;
		}  else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		}
	}

	void state_code_solve_true_3 () {
		text.text = "The current cominbation on the lock reads 4 - 1 - 3 - 1. Enter the fourth number" +
			" or return searching the room.\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.code_solve_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.code_solve_true_4;
		}  else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.escaped;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.room1_escape;
		}
	}

	void state_psych_escape () {
		text.text = "You try opening the door. It's locked.\n\n" +
		"Hey! No answer. \n\nYou take a look around you." +
		"The room is surprisingly... cozy. " +
		"The sheets on the bed are decorated with flowers the room smells like sweet perfume. You notice the reflection of the soft glow of your flashlight coming from a mirror on top of a vanity in the corner of the room.\n\n" +
		"This is weird...\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.psych_escape2;
		}
	}

	void state_psych_escape2 () {
		if (stateController.itemThree == "mirror") {
			text.text = "With mirror in hand you look around at the room. No windows to crawl through and no other doors to open you have limited options. What do you do?\n\n" +
			"Press B to investigate the Bed\n" +
			"Press D to investigate the Door\n" +
			"Press V to investigate the Vanity";
			if (Input.GetKeyDown (KeyCode.V)) {
				myState = States.psych2_vanity;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.psych1_bed;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.psych2_door;
			}
		} else {
			text.text = "With no windows to crawl through and no other doors to open you have limited options. What do you do?\n\n" +
			"Press B to investigate the Bed\n" +
			"Press D to investigate the Door\n" +
			"Press V to investigate the Vanity";
			if (Input.GetKeyDown (KeyCode.V)) {
				myState = States.psych1_vanity;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.psych1_bed;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.psych1_door;
			}
		}
	}

	void state_psych1_door() {
		text.text = "You walk over to the door. \n\nStrange, it doesn't look the same on the outisde. " +
		"On the outside it was cold and metallic, but it looks like it's made out of... wood?! There's something hanging on the door." +
		"You grab the item. It's someone's bathrobe.\n\n" +
		"Press I to investigate the robe further\n" +
		"Press D to investiate the door further\n" +
			"Press R to return to the room";

		if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.psych1_robe;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych1_door2;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape2;
		}
	}

	void state_psych1_door2 () {
		if (stateController.itemFour == "mirror") {
			text.text = "You walk over to the door\n\n" +
			"There's some sort of robe on the floor." +
			"The door is beautifully carved wood. Much more fitting for a bedroom than a patients room at an asylum.\n\n" +
			"You notice there's a slot in the middle of the door. " +
			"That must be how the patient got their meals\n\n" +
			"What do you do?\n\n" +
			"Press I to Investigate the robe\n" +
			"Press L to check out the Lock\n" +
			"Press R to return exploring the room";

			if (Input.GetKeyDown (KeyCode.I)) {
				myState = States.psych2_robe;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.psych_escape3;
			} else if (Input.GetKeyDown (KeyCode.L)) {
				myState = States.psych2_lock;
			}
		} else { 
			text.text = "The door is beautifully carved wood. Much more fitting for a bedroom than a patients room at an asylum.\n\n" +
			"You notice there's a slot in the middle of the door. " +
			"That must be how the patient got their meals\n\n" +
			"You take a look through the slot. All you see is darkness even with the light from your flashlight. If only there was a way to see the lock...\n\n" +
			"Press I to Investigate the robe further\n" +
			"Press R to return exploring the room";

			if (Input.GetKeyDown (KeyCode.I)) {
				myState = States.psych1_robe;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.psych_escape2;
			}
		}
	}

	void state_psych1_robe () {
		text.text = "You take a look at the robe. \n\nIt's black and soft to the touch. As you're examining it, a picture falls to the floor." +
			"It's burnt and melted but you can make out the two faces in the picture. \n\nAs you stare at it fear sets in. Your eyes widen. You can feel your heart rate increase. " +
			"You breathe heavily as you realize it's a picture of your father. \n\nWho's room was this?\n\n" +
			"Press D to investgate the Door\n" +
			"Press R to return searching the Room";
		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych1_door2;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape2;
		}
	}

	void state_psych1_bed() {
		text.text = "You walk over to the bed. You run your hands on the beautifully decorated duvet. Much comfier than the beds your parents had to sleep in..." +
		"The smell of perfume is strong here.\n\n" +
		"The bed frame is made of wood. It's solid, almost looks hand crafted. Whoever stayed here was no ordinary patient.\n\n" +
		"Press R to return exploring the room";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.psych_escape2;
			}
	}

	void state_psych1_vanity() {
		if (stateController.itemFour == "mirror") {
			text.text = "You walk over to the vanity. Similar to the bed, it looks handcrafted out of wood.\n\n" +
			"You take a seat in the chair.\n\n" +
			"What do you do?\n\n" +
			"Press D to check out the Drawers\n" +
			"Press R to return searching the room";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.psych_drawers;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.psych_escape2;
			}
		} else {
			text.text = "You walk over to the vanity. Similar to the bed, it looks handcrafted out of wood.\n\n" +
			"You take a seat in the chair. You spot the hand mirror you caught the reflection of your flashlight in. There are also some drawers in the vanity.\n\n" +
			"What do you do?\n\n" +
			"Press M to pickup with Mirror\n" +
			"Press D to check out the Drawers\n" +
			"Press R to return searching the room";
			if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.psych_mirror_pickup;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.psych_drawers;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.psych_escape2;
			}
		}
	}

	void state_psych_drawers() {
		text.text = "You open the drawers of the vanity.\n\n" +
			"In the first drawer you find a brush and some hair products. You rummage further to find" +
			" a bottle of perfume. In the second drawer you find some drawings.\n\n" +
			"The first couple of drawings looks like fruit and some scenery peices. The last drawing is of a beautiful girl. It looks like Clarissa.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych1_vanity;
		}
	}

	void state_psych_mirror_pickup() {
		stateController.itemFour = "mirror";
		text.text = "You pick up the mirror.\n\nIt's a hand mirror and feels like it's made out of pewter. It's nicely decorated, like something " +
			"our of a fairy tale. \n\nThe flashlight glows softly in the reflection of the mirror\n\n" +
			"Press Space to continue.";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.psych_escape2;
		}
	}
		

	void state_psych2_robe () {
		text.text = "You take a look at the robe. \n\nIt's black and soft to the touch. As you're examining it, a picture falls to the floor." +
			"It's burnt and metlted but you can make out the two faces in the picture. \n\nAs you stare at it fear sets in. Your eyes widen. You can feel your heart start racing. You breathe heavily as you realize it's a picture of your parents. \n\nWho's room was this?\n\n" +
			"Press D to investgate the Door\n" +
			"Press R to return searching the Room";
		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych2_door;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape3;
		}
	}
		
	void state_psych2_lock () {
		text.text = "You set the flashlight on the lip of the slot and hold the mirror outside the door. The limited light provides enough for you to see that the lock requires a 4 digit code." +
			" What do you do?\n\n" +
			"Press U to attempt to Unlock the door\n"+ 
			"Press E to keep Exploring the room";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.psych_code_scene;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.psych_escape3;
		}
	}

	void state_psych_code_scene () {
		text.text = "The current combination on the lock reads 1 - 1 - 1 - 1. Enter the first number" +
			" or continue searching the room\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.psych_code_null1;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych_code_null1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.psych_code_null1;
		}  else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych_code_null1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych2_door;
		}
	}

	void state_psych_code_null1 () {
		text.text = "You set the number in place. Just as you're about to move onto the next number something in the mirror catches your eye. " +
			"Frozen, your eyes widen as your heart begins to race.\n\n" +
			"There is a woman under the bed watching you, smiling.\n\n" +
			"Suddenly, a hand reaches out from the shadows outside the door and grabs your hand violently." +
			"You try to get your arm inside but the stregnth of this person is too great." +
			" Just as you imagine the worst, the arm dissapears back into the darkness." +
			" You take a look at the lock. It's been resent.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.psych_transition;
		}
	}

	void state_psych_transition () {
		text.text = "Freaked out, you take a breath.\n\nYou can feel the woman staring at your from under the bed, burning a whole in the back of your head\n\n" +
			"What do you do?\n\n" +
			"Press B to investigate the bed\n" +
			"Press U to try unlockin the door again";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych3_bed;
		} else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.psych_code1;
		}
	}

	void state_psych3_bed () {
		text.text = "You walk towards the bed, trying to keep your distance. You begin talking outloud.\n\n" +
			"Hi. I know you're under the bed. You can come out.\n\n" +
			"No response. I'm not going to hurt you, I just want to talk." +
			"You quickly bend down to look under the bed.\n\n" +
			"She's gone." +
			"You notice there's blood under the bed and what looks like some finger nails..." +
			"She carved out 3 - 3 - 2 - 4 into the floor.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.psych_escape_4;
		}
	}

	void state_psych_escape_4 () {
		text.text = "You need to escape. What do you do?\n\n" +
			"Press B to investigate under the Bed\n" +
			"Press D to investigate the Door";
		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych3_bed;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych_code1;
		}
	}

	void state_psych_code1 () {
		text.text = "The current combination on the lock reads 1 - 1 - 1 - 1. Enter the first number" +
		" or continue searching the room\n\n" +
		"Press A to keep it at 1\n" +
		"Press B to enter 2\n" +
		"Press C to enter 3\n" +
		"Press D to enter 4\n\n" +
		"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.psych_code2;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape_4;
		}
	}

	void state_psych_code_null () {
		text.text = "You set the number the number in place. Just as you're about to move onto the next number a hand reaches out from the shadows and grabs your hand violently.\n\n" +
			"You try to get your arm inside but the strength of this person is too great.\n\nJust as you imagine the worst, the arm dissapears back into the darkness." +
			"You take a look at the lock. It's been resent.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.psych_code1;
		}
	}

	void state_psych_code2 () {
		text.text = "The current combination on the lock reads 3 - 1 - 1 - 1. Enter the second number" +
			" or continue searching the room\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.psych_code3;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape_4;
		}
	}

	void state_psych_code3 () {
		text.text = "The current combination on the lock reads 3 - 3 - 1 - 1. Enter the third number" +
			" or continue searching the room\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych_code4;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape_4;
		}
	}

	void state_psych_code4 () {
		text.text = "The current combination on the lock reads 3 - 3 - 2 - 1. Enter the last number" +
			" or continue searching the room\n\n" +
			"Press A to keep it at 1\n" +
			"Press B to enter 2\n" +
			"Press C to enter 3\n" +
			"Press D to enter 4\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.psych_code_null;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.escaped;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.psych_escape_4;
		}
	}

	void state_escaped () {
		text.text = "You walk out into the dark hallway\n\n" +
			" Who was it that locked you in there and why? You stand quietly. A part of you" +
			" is debating leaving this place. The other is quietly listening for any signs of life around you. This is way more than you bargained for\n\n" +
			"Press Space to continue";
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.escaped_2;
		}
	}

	void state_escaped_2 () {
		text.text = "You think about the news papers. You think about the headlines. You think about all the words breathed by people who didn't even know your parents\n\n" +
			"You know they didn't commit those crimes they were accused of. You know their death wasn't a suicide. You have to keep on. You have to clear their name.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.escaped_hallway;
		}
	}

	void state_psych_escaped () {
		text.text = "You walk out of the room caustiously.\n\n" +
			"Something really strange is going on. Who slammed the door? Why does that room look different from all the other rooms?\n\n" +
			"Who's room was that? So many questions... This is way more than you signed up for. \n\n" +
			"Press Space to continue";
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.psych_escaped_2;
		}
	}

	void state_psych_escaped_2 () {
		text.text = "For a moment, you think about leaving this place." +
		"Then you think about the news papers. You think about the headlines. You think about all the words breathed by people who didn't even know your parents\n\n" +
		"You know they didn't commit those crimes they were accused of. You know their death wasn't a suicide. You have to keep on. You have to clear their name.\n\n" +
		"Press Space to continue";
	}



	void state_escaped_hallway () {
		text.text = "There doesn't seem to be anyone else out in the hall. You remember the waiting area is just to your left. To your right is the cafeteria doors and basement doors.\n\nWhat do you do?\n\n" +
				"Press A to try opening Room 2 \n" +
				"Press B to investigate the Basement. There may be a way to turn on the power down there.\n" +
				"Press C to venture into the Dining Hall. That's where the kitchens are. \n" +
				"Press R to return to the Waiting Room";
			if (Input.GetKeyDown(KeyCode.A)) {
				myState = States.escaped_room2;
			} else if (Input.GetKeyDown(KeyCode.B)) {
				myState = States.escaped_basement_door;
			} else if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.escaped_dhall;
			} else if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.escaped_asylum;
			}
		}

	void state_escaped_room2 () {
		text.text = "You walk up to the closed door of Room 2. You try the door knob.\n\nIt's locked.\n\n" +
		"Press R to return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.escaped_hallway;
		}
	}

	void state_escaped_basement_door () {
		text.text = "You walk over to the basement door. \n\nIt's locked.\n\n" +
			"If there's a way to turn the power on in this place it's probably in the basement." +
			"You wonder if the person who locked you in that room might be down there.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.escaped_hallway;
		}
	}

	void state_escaped_dhall () {
		text.text = "You walk up to the Dining Hall Doors. The door is ajar and it looks like there's... blood on the floor.\n\n" +
			"Press D to Venture into the Dining Hall\n" +
			"Press R to keep exploring the Asylum";
		if (Input.GetKeyDown(KeyCode.D)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.escaped_hallway;
		}
		
	}

	void state_escaped_asylum () {
		text.text = "You walk back to the front of the Asylum.\n\n" +
		"Across the room is the medical wing. You shiver at the thought of going in there.\n\n" +
		"Of course, you could always look through Clarissa's desk. There could be answers there.\n\n" +
		"What do you do?\n\n" +
		"Press H to walk down the Hallway\n" +
		"Press M to check out the Medical wing\n" +
		"Press D to check out the desk.";
		if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.escaped_hallway;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.escaped_medical_doors;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.escaped_desk;
		}
	}
		
	void state_escaped_medical_doors () {
		text.text = "You walk up to the doors of the Medical Wing.\n\n" +
			"Last you heard your parents were locked up here in their final days.\n" +
			"You were told there was nothing that could be done after the incident but you just know something isn't right with their deaths\n\n" +
			"A part of you knows the answers you need are behind these doors." +
			"You stare at the windows of the doors. Is that... are those scratch marks on the glass?\n\n" +
			"Press Space to conintue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.escaped_medical_doors_2;
		} 
	}

	void state_escaped_medical_doors_2 () {
		text.text = "You read the name on the door. You try opening the door.\n\n" +
			"Locked.\n\n" +
			"You look for the lock and notice there's a keypad. You press some numbers but it's not responding." +
			"There must be a way to get this working...\n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.escaped_asylum;
		} 
	}


	void state_escaped_desk () {
		text.text = "You walk over to the desk.\n\n" +
			"Press C to check the computer. There could be some answers on there.\n" +
			"Press M to check the visitor pamphlets. You remember there was a map on there.\n" +
			"Press D to check the drawers. Maybe Clarissa tucked something away?\n" +
			"Press R to return to the front";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.escaped_asylum;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.escaped_map;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.escaped_drawers;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.escaped_computer;
		}
	}

	void state_escaped_map () {
		text.text = "You take a look at a bunch of pamphlets sitting on Clarissa's desk. She would give these " +
			"out to the guests who didn't know there way around.\n\nYou scan the map quickly." +
			"You notice there's basement to this place. If there's a way to get the power running, it's probably down there.\n\n" +
			"The map indiciates there's a door to the basement just down the hall. There's also one in the kitchens beside the dining hall." +
			"The door the dining hall is also just down the hallway. Convenient.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.escaped_desk;
		}
	}

	void state_escaped_drawers () { //include newspaper clippings of your parents with their faces scratched out
		text.text = "You try opening the drawer of the desk.\n\n" +
			"It's locked\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.escaped_desk;
		}
	}

	void state_escaped_computer () {
		text.text = "You sit down at the desk. " +
			"You see a computer mouse and give a shake. " +
			"Nothing.\n\n" +
			"You notice a computer tower under the desk. You press the power button. And then again." +
			"Nothing.\n\n" +
			"There doesn't seem to be any power.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.escaped_desk;
		}
	}
}