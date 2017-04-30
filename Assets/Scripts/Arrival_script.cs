using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Arrival_script : MonoBehaviour {

	public Text text;
	public int psychValue = 0;
	private PsychController psychController;
	private States myState;
	private enum States { arrival_1, arrival_2, arrival_3, arrival_4, arrival_5, decisions, decision_1, decision_2, decision_3, 
		door, knock, knock_2, windows, open_window, car, building, 
		car_2, shed, knock_3, door_2, door_3, windows_2, windows_3, smash, hammer,
	building_scene, door_smash, door_pick, wire};




	// Use this for initialization
	void Start () {
		myState = States.arrival_1;
		GameObject psychControllerObject = GameObject.FindWithTag ("PsychCounter");

		if (psychControllerObject != null) {
			psychController = psychControllerObject.GetComponent <PsychController> ();
		}
		if (psychController == null) {
			Debug.Log ("Cannot find 'PsychController' script");
		}
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
		} else if (myState == States.knock) {
			state_knock ();
		} else if (myState == States.car) {
			state_car ();
		} else if (myState == States.car_2) {
			state_car_2 ();
		} else if (myState == States.windows) {
			state_windows ();
		} else if (myState == States.windows_2) {
			state_windows_2 ();
		} else if (myState == States.building) {
			state_building ();
		} else if (myState == States.shed) {
			state_shed ();
		} else if (myState == States.door_2) {
			state_door_2 ();
		} else if (myState == States.windows_3) {
			state_windows_3 ();
		} else if (myState == States.smash) {
			state_smash ();
		} else if (myState == States.arrival_3) {
			state_arrival_3 ();
		} else if (myState == States.arrival_4) {
			state_arrival_4 ();
		} else if (myState == States.decision_1) {
			state_decision_1 ();
		} else if (myState == States.decision_2) {
			state_decision_2 ();
		} else if (myState == States.decision_3) {
			state_decision_3 ();
		} else if (myState == States.decisions) {
			state_decisions ();
		} else if (myState == States.arrival_5) {
			state_arrival_5 ();
		} else if (myState == States.open_window) {
			state_open_window ();
		} else if (myState == States.hammer) {
			state_hammer ();
		} else if (myState == States.building_scene) {
			state_building_scene ();
		} else if (myState == States.door_smash) {
			state_door_smash ();
		} else if (myState == States.door_3) {
			state_door_3 ();
		} else if (myState == States.knock_2) {
			state_knock_2 ();
		} else if (myState == States.door_pick) {
			state_door_pick ();
		} else if (myState == States.wire) {
			state_wire ();
		}
	} 
	//Call the different states in the scene
			void state_arrival_1(){
				text.text = "You're driving.\n\n" +
			"The headllights of on-coming traffic blind you as quickly as they fade away into the night\n\n"+
			"You don’t remember leaving your house or getting into the car. Your head feels fuzzy. " +
			"All you know is that you need to clear your parents names.\n\n"+
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
		"You take a breath, close your eyes and embrace the silence around you.\n\n" +
		"The silence inside the car makes you uneasy despite the distant groan of the cars from the highway.\n\n" +
		"Press Space Bar to continue";
		
		if (Input.GetKeyUp (KeyCode.Space)) {
				}
				if (Input.GetKeyDown (KeyCode.Space)) {
							myState = States.arrival_4;
						}
			}

			void state_arrival_4 () {
		text.text = "You think about what you’re going to say to the admin at the front desk. You wonder if Clarissa is working today. " +
		"What can you do to convince them to have you look around? \n\n" +
		"What will you do?\n\n" +
		"Press Space to continue";
		if (Input.GetKeyUp (KeyCode.Space)) {
		}

		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.decisions;
			}

	void state_decisions () {
		text.text = "Press A for:You’ll force your way in if you have to. You don’t care about anyone and anything other than finding answers.\n\n" +
		"Press B for:You're confident you can turn the charm on and lie to them and convince them to let you look around\n\n" +
		"Press C for:You’ll tell them the truth. You’re confident they’ll empathize and help you.";
		if (Input.GetKeyUp (KeyCode.Space)) {
			
		}
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.decision_2;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.decision_1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.decision_3;
		}
	}

			void state_decision_1 () {
		psychController.AddPsychCounter (psychValue + 2);
		text.text = "You're confident you can turn on the charm and lie to them. Convince them to let you look around.\n\n" +
		"Press Space to continue";
		if (Input.GetKeyUp (KeyCode.B)) {

		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			
			myState = States.arrival_5;
		}
			}

			void state_decision_2 () {
		psychController.AddPsychCounter (psychValue + 4);
				text.text = "You’ll force your way in if you have to. You don’t care about anyone and anything other than finding answers\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.arrival_5;
		}
			}

			void state_decision_3 () {
				text.text = "You’ll tell them the truth. You’re confident they’ll empathize and help you\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.arrival_5;
		}
			}

	void state_arrival_5 () {
		text.text = "You look up at the Asylum.\n\n" +
			"There are no lights on. That’s weird.\n\n" +
			"You get out of the car and begin walking up to the building. You make your way to the door " +
			"and try to open it. It's locked.\n\n"+
			"Back when you used to visit your parents here the door was never locked. What do you do?\n\n"+
			"Press Space to continue";
		if (Input.GetKeyUp (KeyCode.Space)) {
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.door;
		}
	}

	void state_door () {
		text.text = "To your right you see some Windows. You could try there. " +
		"It also might be worth taking a look around the building. " +
		"You glance back at your car. You could have something useful in the trunk\n\n" +
		"Press W to check the Windows\n" +
		"Press B to take a look around the Building\n" +
		"Press C to check out the Car";
		if (Input.GetKeyUp (KeyCode.Space)) {
			
		} if (Input.GetKeyUp (KeyCode.R)) {
			
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			
			myState = States.windows;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			
			myState = States.building;
		} else if (Input.GetKeyDown (KeyCode.C)) {
		
			myState = States.car;
		}
	}

	void state_car () {
		text.text = "You walk back to your car and open the the driver side door. You reach over and open the glove box.\n\n" +
			"You see a safety blanket, your insurance and your wallet. A picture falls out of the wallet as you rummage through your stuff." +
			"It's a picture of your family, mom, dad and your brother.\n\n" +
			"You look so happy. You forgot you were all so happy once. You don’t see much in the the car that will help you out.\n\n" +
			"Press R to return to the front";
		if (Input.GetKeyUp (KeyCode.C)) {
	
		}
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
		if (Input.GetKeyUp (KeyCode.B)) {

		}

		if (Input.GetKeyDown (KeyCode.R)) {

			myState = States.door;
		} else if (Input.GetKeyDown (KeyCode.S)) {

			myState = States.shed;
		}
	}

	void state_windows () {
		text.text = "You walk up to the windows and look inside.\n\n" +
		"It’s dark. You can't see much inside.\n\n" +
		"You can make out a dim light off in the distance. The light flickers. " +
		"Seems like someone is inside.\n\n" +
		"Press O to try Opening the window\n" +
		"Press R to return to the front";
		if (Input.GetKeyUp (KeyCode.W)) {
	
		}

		if (Input.GetKeyDown (KeyCode.O)) {
	
			myState = States.open_window;
		} else if (Input.GetKeyDown (KeyCode.R)) {

			myState = States.door;
		}
	}

	void state_open_window () {
		text.text = "You try opening the window\n\n" +
		"It doesn't budge. You can see the latch that's leeping it closed through the window\n\n" +
		"Press R to return to the front";
		if (Input.GetKeyDown (KeyCode.R)) {

			myState = States.door;
		}
	}

	void state_shed () {
		if (psychController.psychCounter >= 5) {
			text.text = "You walk up to the shed and open the door. Everything looks old and unused, forgotten almost.\n\n" +
			"You feel around in the darkness for anything that might help.\n\n" +
			"You touch what feels like a garden hose, and then a watering can. With the little light you have you make out a carpenters hammer.\n\n" +
			"Press P to Pickup the hammer\n" +
			"Press R to return to front"; 
		} else if (psychController.psychCounter <= 3) {
			text.text = "You walk up to the shed and open the door. Everything looks old and unused, forgotten almost.\n\n" +
				"You feel around in the darkness for anything that might help.\n\n" +
				"You touch what feels like a garden hose, and then a watering can. With the little light you have you make out some copper wire\n\n" +
				"Press G to Grab the wire\n" +
				"Press R to return to front";
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.wire;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door;
		}
	}

	void state_hammer () {
		text.text = "You pick up the hammer.\n\n" +
			"It feels heavy in your hand, but strangely familiar. Like the grip fits your palm perfectly.\n\n"+
			"Press Space to continue";
		if (Input.GetKeyUp (KeyCode.P)) {
		
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.building_scene;
		}
	}

	void state_wire () {
		text.text = "You grab the copper wire.\n\n" +
		"You feel like you're having deja vu. But when is the last time you were holding copper wire in a dark shed at an Asylum?\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.building_scene;
		}
	}

	void state_building_scene () {
		text.text = "You begin walking back to the door.\n\n" +
		"Something in one of the windows catches the corner of your eye." +
		"You look up to see the grim face of a woman staring down at you. Her eyes are fixated on you, never blinking. " +
		"She must be a patient you think to yourself. She looks familiar. You must have seen her before when visiting you parents.\n\n" +
		"You try not to pay attention but as you walk back to the front of the building her gaze follows you.\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.door_2;
		}
	}

			void state_door_2 () {
		if (psychController.psychCounter >= 5) {
			text.text = "You make it to the front of the Asylum with hammer in hand.\n\n" +
			"What do you do?\n\n" +
			"Press O to try Opening the front door again.\n" +
			"Press C to Check your Car\n" +
			"Press W to investigate the Windows\n";
		} else if (psychController.psychCounter <= 3) {
			text.text = "You make it to the front of the Asylum with copper wire in hand.\n\n" +
				"What do you do?\n\n" +
				"Press O to try Opening the front door again.\n" +
				"Press C to Check your Car\n" +
				"Press W to investigate the Windows\n";
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.door_3;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.car_2;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.windows_2;
		}
	}

	void state_car_2 () {
		text.text = "You walk up to your car. Maybe you forgot something.\n\n" +
			"You check the trunk and find your gym bag, a spare tire and your baseball gear. You were never very good at baseball " +
			"but you always loved playing with your brother. He was the athlete of the family.\n\n" +
			"Suddenly someting catches the corner of you eye\n\n" +
			"You look up at the window to where the woman was staring down at you. She’s gone.\n\n" +
			"Press R to return to the front";
		if (Input.GetKeyDown (KeyCode.R)) {
	
			myState = States.door_2;
		}
	}

	void state_door_3 () {
		if (psychController.psychCounter >= 5) {
			text.text = "You walk up to the door.\n\n" +
			"If that patient is up in her room, there must still be orderly around.\n\n" +
			"You gaze down at the hammer you're holding and then up at the door.\n\n" +
			"What do you do?\n\n" +
			"Press K to Knock on the door\n" +
			"Press B to Break the door in the with the hammer\n" +
			"Press R to return";
		} else if (psychController.psychCounter <= 3) {
			text.text = "You walk up to the door.\n\n" +
				"If that patient is up in her room, there must still be orderly around.\n\n" +
				"You gaze down at the copper wire you're holding and then up at the door.\n\n" +
				"What do you do?\n\n" +
				"Press P to try and Pick the lock with the wire\n" +
				"Press R to return";
		}
		 if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.door_pick;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door_2;
		}	
	}

	void state_door_pick () {
		text.text = "You bend down and straighten out the copper wire. You've never picked a lock in your life but you give it a shot." +
			" After a couple minutes of twisting and turning the wire in the lock, you give up.\n\n" +
			"You suddenly hear something from behind the door. You press your ear against the door and listen." +
			" You hear something faint... What is that? Is that someone breathing?\n\n" +
			"Hello? You call out.\n" +
			"You hear the faint sound of footsteps walking away from the door.\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door_2;
		}
	}

	void state_door_smash () {
		psychController.AddPsychCounter (psychValue + 1);
		text.text = "You lift the hammer into the air. With swiftness and strength you slam your hammer down onto the door handle\n\n" +
			"The slamming echoes off the inner walls of the Asylum and into the night. " +
			"You strike handle and wood over and over again. Splinters fly out as you mangle the door\n\n" +
			"The door opens." +
			"You stop for a moment and listen intently...\n\n" +
			"Silence.\n\n" +
			"What the hell is going on? Someone should have heard that.\n\n" +
			"Press Space to Enter the Asylum";
		if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);;
		}
	}

	void state_knock() {
		text.text = "You knock on the door in hopes that someone answers." +
		"You've never seen this placed locked before, let alone with no lights on inside." +
		"You listen intently...\n\n" +
		"Silence.\n\n" +
		"You knock again... nothing. You press your ear up to the door and listen for footsteps or voices or anything.\n\n" +
		"You hear something faint... What is that? Is that someone breathing?\n\n";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.knock_2;
		}
	}

	void state_knock_2 () {
		text.text = "Hello? You call out.\n\n" +
		"You hear the faint sound of footsteps walking away from the door. " +
		"This is so... strange.\n\n" +
		"It doesn't look like anyone is opening up.\n\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door_2;
		}
	}

	void state_windows_2 () {
		if (psychController.psychCounter >= 5) {
			text.text = "You make it to the window.\n\n" +
			"You take a peek through the glass and can see a dim light off into the distance." +
			" You hope to see someone but there's no one in sight.\n\n" +
			"You look down at your hammer. \n\n" +
			"What do you do?\n\n" +
			"Press S to Smash the Window open\n" +
			"Press P to Pry the Window open\n" +
			"Press R to Return";
		} else if (psychController.psychCounter <= 3) {
			text.text = "You make it to the window.\n\n" +
				"You take a peek through the glass and can see a dim light off into the distance." +
				" You hope to see someone but there's no one in sight.\n\n" +
				"You look down at the copper wire in your hand.\n\n" +
				"What do you do?\n\n" +
				"Press U to Unlock the window with the wire\n" +
				"Press R to Return";
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.windows_3;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.door_2;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.smash;
		} else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.windows_3;
		} 
	}

	void state_windows_3 () {
		if (psychController.psychCounter >= 5) {
			text.text = "You turn the hammer around and begin to pry the Window open.\n\n" +
			"The light off in the distance flickers. Is there someone there?" +
			" You stop for a moment and look past the darkness of the room and into the hallway where the dim light shines\n\n" +
			"Nothing.\n\n" +
			"With a little force you pry the window open.\n\n" +
			"Press Space to continue into the Asylum.";
		} else if (psychController.psychCounter <= 3) {
			text.text = "You twist the wire into a hook\n\n" +
				"The light off in the distance flickers. Is there someone there?" +
				" You stop for a moment and look past the darkness of the room and into the hallway where the dim light shines\n\n" +
				"Nothing.\n\n" +
				"With a little force you push the wire under the window and hook the lock open.\n\n" +
				"Press Space to continue into the Asylum.";
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}


	void state_smash () {
		psychController.AddPsychCounter (psychValue + 1);
		text.text = "You lift the hammer into the air. With swiftness and stregnth you slam your hammer through the glass.\n\n" +
			"The smash echoes off the inner walls of the Asylum and into the night. " +
			"You stop for a moment and listen intently...\n\n" +
			"Silence.\n\n" +
			"What the hell is going on? Someone should have heard that.\n\n" +
		"Press Space to Enter the Asylum";
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}

