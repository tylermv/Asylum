using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {


	public Text text;

	private States myState;
	private enum States {arrival_1, arrival_2, door, open_door, knock, knock_2, windows, car, building, 
		car_2, shed, knock_3, door_2, windows_2, windows_3};


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
		} else if (myState == States.open_door) {
			state_open_door ();
		} else if (myState == States.knock) {
			state_knock ();
		} else if (myState == States.knock_2) {
			state_knock_2 ();
		} else if (myState == States.knock_3) {
			state_knock_3 ();
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
		}

	} 
	//Call the different states in the scene
			void state_arrival_1(){
				text.text = "You open the gates to The Asylum.\n\n" +
				"Here your parents were committed. You think about how committed is a funny word. " +
				"Committed a crime. Committed to the institute. Committed suicide...\n\n" +
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
						"You're about to knock when you're stricken by fear." +
						"You don't know what you'll do once you get in, but you have to clear your families name. What do you do?\n\n" +
						"To Knock on the door press K\n" +
						"To Walk into the Asylum press W";

				if (Input.GetKeyDown (KeyCode.K)) {
					myState = States.knock;
				} else if (Input.GetKeyDown (KeyCode.O)) {
					myState = States.open_door;
					}
				}
				
			void state_knock() {
				text.text = "You knock on the Asylum door. You hear nothing." +
				"You knock again. Nothing." +
				"You try the door handle but it seems to be locked. Whenever you visited your parents the door was always open." +
				"Strange, you think. Better take a look around.\n" +
				"Press Space Bar to continue";

				if (Input.GetKeyDown (KeyCode.Space)) {
					myState = States.knock_2;
					}
				}
			
			void state_knock_2 () {
				text.text = "To your right you see some Windows. If they open you could climb through. You wonder if it's maybe " +
					"worth taking a look around the building. You glance back at your car. You could have something useful in the trunk\n" +
					"Press W to check the Windows\n" +
					"Press B to take a look around the Building\n" +
					"Press C to check out the Car";
				if (Input.GetKeyDown (KeyCode.W)) {
					myState = States.windows;
				} else if (Input.GetKeyDown (KeyCode.B)) {
					myState = States.building;
				} else if (Input.GetKeyDown (KeyCode.C)) {
					myState = States.car;
				}
			}
			
			void state_open_door () {
				
			}

			void state_car () {
		text.text = "car\n\n" +
		"Press R to return to the front";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_2;
		}
			}

			void state_car_2 () {
		text.text = "car 2\n\n" +
		"Press R to return to the front";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_3;
		}
			}

			void state_building () {
		text.text = "You walk around the Asylum. There are no lights on in the building. It's hard to see anything. " +
		"You stumble upon an old shed.\n\n" +

		"Press S to investiagte the Shed\n" +
		"Press R to Return to the front";
		

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_2;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.shed;
		}
			}

			void state_windows () {
				text.text = "You try to take a peak inside. There are no lights on, it's hard to see anything. " +
			"You attempt to open the window.\n\n" +
			"It won't budge\n\n" +
			"Press R to return to the front";

			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.knock_2;
			}
		}

			void state_shed () {
			text.text = "You rustle through the shed. You find an Item. This could come in handy.\n\n" +
			"Press R to return to front"; 

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_3;
			}
		}

			void state_knock_3 () {
				text.text = "You walk back to the front of the Asylum.\n\n" +
				"Press O to try Opening the front door again.\n" +
				"Press C to Check your Car\n" +
				"Press W to investigate the Window\n";
					if (Input.GetKeyDown (KeyCode.O)) {
						myState = States.door_2;
					} else if (Input.GetKeyDown (KeyCode.C)) {
						myState = States.car_2;
					} else if (Input.GetKeyDown (KeyCode.W)) {
						myState = States.windows_2;
					}
	}

			void state_door_2 () {
		text.text = "Door 2\n\n" +
		"Press R to Return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_3;
		}
	}

	void state_windows_2 () {
		text.text = "Windows 2\n\n" +
			"Press I to use Items on the Windown\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.windows_3;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_3;
		}
	}

	void state_windows_3 () {
		text.text = "You use the Item on the Window. " +
			"With some force the window pries open.\n\n" +
			"Press C to climb through thr window\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.C)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.knock_3;
		}
	}
}

//To Do: Set the psychpath counter in the case that they just try to walk in and add it to the scene

