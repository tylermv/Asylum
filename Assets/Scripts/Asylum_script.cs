using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Asylum_script : MonoBehaviour {

	public Text text;

	public States myState;
	public enum States {asylum_1, asylum_2, asylum_silver, asylum_map, asylum_both, solitary_1, desk, hallway, room1, room2, room3, room4, dhall, topdesk, topdesk_2, leftdrawer
		, bottomdrawer, map, notebook, computer, silver_key, desk_silver, hallway_silver, room4_silver, topdesk_silver, 
		bottomdrawer_silver, map_silver, notebook_silver, computer_silver, room4_drawer, hallway_rusty, asylum_rusty, 
		room4_rusty, room3_rusty, hallway_rusty_2, room3_rusty_2, room4_rusty_2, solitary_rusty, desk_rusty, room2_rusty, room1_rusty, 
		solitary_silver, room1_silver, room2_silver, room3_silver, dhall_silver, dhall_rusty, room1_rusty_2, room2_rusty_2, 
	dhall_rusty_2, room4_rusty_3, asylum_rusty_2, solitary_rusty_2, desk_rusty_2, topdesk_rusty_2, notebook_rusty_2, 
	computer_rusty_2, map_rusty_2, topdesk_rusty, map_rusty, notebook_rusty, computer_rusty, bottomdrawer_rusty, bottomdrawer_rusty_2, 
		room2_final, room2_final_2};

	// Use this for initialization
	void Start () {
		myState = States.asylum_1;
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
		} else if (myState == States.topdesk) {
			state_topdesk ();
		} else if (myState == States.leftdrawer) {
			state_leftdrawer ();
		} else if (myState == States.bottomdrawer) {
			state_bottomdrawer ();
		} else if (myState == States.computer) {
			state_computer ();
		} else if (myState == States.notebook) {
			state_notebook ();
		} else if (myState == States.topdesk_2) {
			state_topdesk_2 ();
		} else if (myState == States.map) {
			state_map ();
		} else if (myState == States.silver_key) {
			state_silver_key ();
		} else if (myState == States.desk_silver) {
			state_desk_silver ();
		} else if (myState == States.hallway_silver) {
			state_hallway_silver ();
		} else if (myState == States.bottomdrawer_silver) {
			state_bottomdrawer_silver ();
		} else if (myState == States.topdesk_silver) {
			state_topdesk_silver ();
		} else if (myState == States.notebook_silver) {
			state_notebook_silver ();
		} else if (myState == States.computer_silver) {
			state_computer_silver ();
		} else if (myState == States.map_silver) {
			state_map_silver ();
		} else if (myState == States.asylum_silver) {
			state_asylum_silver ();
		} else if (myState == States.room4_silver) {
			state_room4_silver ();
		} else if (myState == States.room4_drawer) {
			state_room4_drawer ();
		} else if (myState == States.room4_rusty) {
			state_room4_rusty ();
		} else if (myState == States.hallway_rusty) {
			state_hallway_rusty ();
		} else if (myState == States.hallway_rusty_2) {
			state_hallway_rusty_2 ();
		} else if (myState == States.room3_rusty_2) {
			state_room3_rusty_2 ();
		} else if (myState == States.room4_rusty_2) {
			state_room4_rusty_2 ();
		} else if (myState == States.solitary_rusty) {
			state_solitary_rusty ();
		} else if (myState == States.desk_rusty) {
			state_desk_rusty ();
		} else if (myState == States.room1_rusty) {
			state_room1_rusty ();
		} else if (myState == States.room2_rusty) {
			state_room2_rusty ();
		} else if (myState == States.solitary_silver) {
			state_solitary_silver ();
		} else if (myState == States.room1_silver) {
			state_room1_silver ();
		} else if (myState == States.room2_silver) {
			state_room2_silver ();
		} else if (myState == States.room3_silver) {
			state_room3_silver ();
		} else if (myState == States.dhall_silver) {
			state_dhall_silver ();
		} else if (myState == States.dhall_rusty) {
			state_dhall_rusty ();
		} else if (myState == States.dhall_rusty_2) {
			state_dhall_rusty_2 ();
		} else if (myState == States.room1_rusty_2) {
			state_room1_rusty_2 ();
		} else if (myState == States.room2_rusty_2) {
			state_room2_rusty_2 ();
		} else if (myState == States.room3_rusty) {
			state_room3_rusty ();
		} else if (myState == States.room4_rusty_3) {
			state_room4_rusty_3 ();
		} else if (myState == States.asylum_rusty) {
			state_asylum_rusty ();
		} else if (myState == States.asylum_rusty_2) {
			state_asylum_rusty_2 ();
		} else if (myState == States.desk_rusty_2) {
			state_desk_rusty_2 ();
		} else if (myState == States.solitary_rusty_2) {
			state_solitary_rusty_2 ();
		} else if (myState == States.map_rusty_2) {
			state_map_rusty_2 ();
		} else if (myState == States.topdesk_rusty) {
			state_topdesk_rusty ();
		} else if (myState == States.map_rusty) {
			state_map_rusty ();
		} else if (myState == States.notebook_rusty) {
			state_notebook_rusty ();
		} else if (myState == States.computer_rusty) {
			state_notebook_rusty ();
		} else if (myState == States.bottomdrawer_rusty) {
			state_bottomdrawer_rusty ();
		} else if (myState == States.bottomdrawer_rusty_2) {
			state_bottomdrawer_rusty_2 ();
		} else if (myState == States.topdesk_rusty_2) {
			state_topdesk_rusty_2 ();
		} else if (myState == States.notebook_rusty_2) {
			state_notebook_rusty_2 ();
		} else if (myState == States.computer_rusty_2) {
			state_computer_rusty_2 ();
		} else if (myState == States.solitary_rusty_2) {
			state_solitary_rusty_2 ();
		} else if (myState == States.room2_final) {
			state_room2_final ();
		} else if (myState == States.room2_final_2) {
			state_room2_final_2 ();
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
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_2;
		}
			}
		void state_desk () {
		text.text = "Despite the lack of light, you make your way over the front desk. Where do you look?\n\n" +
		"Press T to check the Top of the desk\n" +
		"Press L to check the Left Drawer\n" +
		"Press B to chcke the Bottom Drawer\n" +
			"Press R to return";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.asylum_2;
		} else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.topdesk;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.leftdrawer;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.bottomdrawer;
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
		text.text = "The door seems to be jammed\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway;
			}
		}

	void state_topdesk () {
		text.text = "You take a look at the top of the desk. It's in dissaray. Someone sure left in a hurry\n" +
		"there's a computer that won't turn on, a notebook on the desk and what looks like a map of the asylum\n\n " +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.topdesk_2;

		}
	}

	void state_topdesk_2 () {
		text.text = "Press M to take Map\n " +
		"Press N to take Notebook\n" +
		"Press C to try the computer\n" +
		"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.desk;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.map;
		} else if (Input.GetKeyDown(KeyCode.N)) {
			myState = States.notebook;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.computer;
		} 
	}

	void state_leftdrawer () {
		text.text = "You open the drawer to find some pens and a stapler. \n" +
			"You're shocked to find a toy robot. You pick it up. That's weird.\n" +
			"You look down and find a key.\n\n" +
			"Press P to Pickup the key\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.desk;	
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.silver_key;
		}
	}

	void state_bottomdrawer () {
		text.text = "Welcome to bottom drawer\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.desk;	
			}
		}

	void state_map () {
		text.text = "Welcome to the map\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_2;
		}
	}

	void state_notebook () {
			text.text = "Welcome to bottom notebook\n\n " +
				"Press R to Return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.topdesk_2;
		}
	}

	void state_computer () {
				text.text = "Welcome to bottom computer\n\n " +
					"Press R to Return";
				if (Input.GetKeyDown (KeyCode.R)) {
					myState = States.topdesk_2;
		}
	}

	void state_silver_key () {
		text.text = "It's a shiny silver key. This will probably come in handy later.\n\n" +
			"Press S to keep Searching the desk.\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.desk_silver;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.asylum_silver;
		
		}
	}

	void state_desk_silver () {
		text.text = "Where do you look?\n\n" +
		"Press T to check the Top of the desk\n" +
		"Press B to check the Bottom Drawer\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.asylum_silver;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.topdesk_silver;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bottomdrawer_silver;
		}
	}

		void state_asylum_silver () {
			text.text = "Press D to check the Desk\n" +
				"Press H to travel down the Hallway\n" +
				"Press S to check Solitary confinment";
			if (Input.GetKeyDown(KeyCode.S)) {
				myState = States.solitary_silver;
			} else if (Input.GetKeyDown(KeyCode.D)) {
				myState = States.desk_silver;
			} else if (Input.GetKeyDown(KeyCode.H)) {
				myState = States.hallway_silver;
			}
		}

	void state_solitary_silver () {
		text.text = "You walk up to the Solitary Confinement Door. Last you hear your parents were locked " +
			"up here in the their final days.\n" +
			"You try fiddling with the electric keypad\n" +
			"It's non-responsive. There must be a way to get this working...\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_silver;
		}
	}

		void state_hallway_silver () {
				text.text = "Press A to check out Room 1 \n" +
					"Press B to check out Room 2 \n" +
					"Press C to check out Room 3 \n" +
					"Press D to check out Room 4 \n" +
					"Press E to check out the Dining Hall \n\n" +
					"Press R to return";
				if (Input.GetKeyDown(KeyCode.A)) {
					myState = States.room1_silver;
				} else if (Input.GetKeyDown(KeyCode.B)) {
					myState = States.room2_silver;
				} else if (Input.GetKeyDown(KeyCode.C)) {
					myState = States.room3_silver;
				} else if (Input.GetKeyDown(KeyCode.D)) {
					myState = States.room4_silver;
				} else if (Input.GetKeyDown(KeyCode.E)) {
					myState = States.dhall_silver;
				} else if (Input.GetKeyDown(KeyCode.R)) {
					myState = States.asylum_silver;
				}
			}

	void state_room1_silver () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_silver;
		}
	}

	void state_room2_silver () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_silver;
		}
	}

	void state_room3_silver () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_silver;
		}
	}

	void state_dhall_silver () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_silver;
		}
	}

		void state_bottomdrawer_silver () {
			text.text = "Welcome to bottom drawer\n\n " +
			"Press R to Return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.desk_silver;	
			}
		}

		void state_topdesk_silver () {
			text.text = "Press M to take Map\n " +
				"Press N to take Notebook\n" +
				"Press C to try the computer\n" +
				"Press R to Return";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.desk_silver;
			} else if (Input.GetKeyDown(KeyCode.M)) {
				myState = States.map_silver;
			} else if (Input.GetKeyDown(KeyCode.N)) {
				myState = States.notebook_silver;
			} else if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.computer_silver;
				} 
			}

		void state_map_silver () {
			text.text = "Welcome to the map\n\n " +
			"Press R to Return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.topdesk_silver;
			}
		}

		void state_notebook_silver () {
			text.text = "Welcome to bottom notebook\n\n " +
			"Press R to Return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.topdesk_silver;
			}
		}

		void state_computer_silver () {
			text.text = "Welcome to bottom computer\n\n " +
			"Press R to Return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.topdesk_silver;
			}
		}

		void state_room4_silver () {
			text.text = "Press U to Use the silver key\n" +
				"Press R to Return";

			if (Input.GetKeyDown (KeyCode.U)) {
				myState = States.room4_drawer;
			} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_silver;
			}
		}

		void state_room4_drawer () {
		text.text = "You open up a drawer\n" +
		"You find a rusty key inside\n\n" +
		"Press P to Pickup the rusty key\n" +
		"Press R to Return";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.room4_rusty;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_silver;
		}
	}

		void state_room4_rusty () {
			text.text = "You pick up the rusty key. For some reason, you feel like you've seen this key before.\n " +
			"It feels like something is going on here...\n\n" +
			"Press V to Venture back out into the hall";

			if (Input.GetKeyDown (KeyCode.V)) {
				myState = States.hallway_rusty;
			} 
		}

		void state_hallway_rusty () {
		text.text = "Press A to check out Room 1 \n" +
			"Press B to check out Room 2 \n" +
			"Press C to check out Room 3 \n" +
			"Press D to check out Room 4 \n" +
			"Press E to check out the Dining Hall \n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.room1_rusty;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.room2_rusty;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.room3_rusty;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.room4_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.dhall_rusty;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_rusty;
		}
	}

	void state_asylum_rusty () {
		text.text = "Press D to check the Desk\n" +
			"Press H to travel down the Hallway\n" +
			"Press S to check Solitary confinment";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.solitary_rusty;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.desk_rusty;
		} else if (Input.GetKeyDown(KeyCode.H)) {
			myState = States.hallway_rusty;
		}
	}

	void state_topdesk_rusty () {
		text.text = "Press M to take Map\n " +
			"Press N to take Notebook\n" +
			"Press C to try the computer\n" +
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.desk_rusty;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.map_rusty;
		} else if (Input.GetKeyDown(KeyCode.N)) {
			myState = States.notebook_rusty;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.computer_rusty;
		} 
	}

	void state_map_rusty () {
		text.text = "Welcome to the map\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_rusty;
		}
	}

	void state_notebook_rusty () {
		text.text = "Welcome to bottom notebook\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_rusty;
		}
	}

	void state_computer_rusty () {
		text.text = "Welcome to bottom computer\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_rusty;
		}
	}
		

	void state_room3_rusty () {
		text.text = "Use the rusty key?\n\n" +
		"Press U to Use the rusty key\n" +
		"Press R to return";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.room3_rusty_2;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty;
		}
	}

	void state_room3_rusty_2 () {
		text.text = "You walk into the room. It's completly empty. You notice there's a crumbling \n" +
			"whole in the wall leading into Room 2\n" +
			"Press W to walk into Room 2\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty_2;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.room2_final;
		} 
	}

	void state_hallway_rusty_2 () {
		text.text = "Room 4 Rusty\n" +
		"Press A to check out Room 1\n" +
		"Press B to check out Room 2 \n" +
		"Press C to check out Room 3 \n" +
		"Press D to check out Room 4 \n" +
		"Press E to check out the Dining Hall \n\n" +
		"Press R to return";
		if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.room1_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.room2_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.room3_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.room4_rusty_3;
		} else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.dhall_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_rusty_2;
		}
	}

	void state_solitary_rusty () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.asylum_rusty;
		}
	}

	void state_desk_rusty () {
		text.text = "Where do you look?\n\n" +
			"Press T to check the Top of the desk\n" +
			"Press B to check the Bottom Drawer\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.asylum_rusty;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.topdesk_rusty;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bottomdrawer_rusty;
		}
	}

	void state_bottomdrawer_rusty () {
		text.text = "Welcome to the bottom drawer!\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.desk_rusty;
		}
	}

	void state_room1_rusty () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty;
		}
	}

	void state_room2_rusty () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty;
		}
	}

	void state_dhall_rusty () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty;
		}
	}

	void state_room1_rusty_2 () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty_2;
		}
	}

	void state_room2_rusty_2 () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty_2;
		}
	}

	void state_room4_rusty_2 () {
		text.text = "You see everything you've seen before\n" +
		"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty;
		}
	}

	void state_room4_rusty_3 () {
		text.text = "You see everything you've seen before\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty_2;
		} 
	}

	void state_dhall_rusty_2 () {
		text.text = "It's locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.hallway_rusty_2;
		}
	}
		

	void state_asylum_rusty_2 () {
		text.text = "Press D to check the Desk\n" +
			"Press H to travel down the Hallway\n" +
			"Press S to check Solitary confinment";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.solitary_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.desk_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.H)) {
			myState = States.hallway_rusty_2;
		}
	}

	void state_solitary_rusty_2 () {
		text.text = "You walk up to the Solitary Confinement Door. Last you hear your parents were locked " +
			"up here in the their final days.\n" +
			"You try fiddling with the electric keypad\n" +
			"It's non-responsive. There must be a way to get this working...\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.asylum_rusty_2;
		}
	}

	void state_desk_rusty_2 () {
		text.text = "Where do you look?\n\n" +
			"Press T to check the Top of the desk\n" +
			"Press B to check the Bottom Drawer\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.asylum_rusty_2;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.topdesk_rusty_2;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bottomdrawer_rusty_2;
		}
	}
		

	void state_topdesk_rusty_2 () {
		text.text = "Press M to take Map\n " +
			"Press N to take Notebook\n" +
			"Press C to try the computer\n" +
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.desk_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.map_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.N)) {
			myState = States.notebook_rusty_2;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.computer_rusty_2;
		} 
	}

	void state_map_rusty_2 () {
		text.text = "Welcome to the map\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_rusty_2;
		}
	}

	void state_notebook_rusty_2 () {
		text.text = "Welcome to bottom notebook\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_rusty_2;
		}
	}

	void state_computer_rusty_2 () {
		text.text = "Welcome to bottom computer\n\n " +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.topdesk_rusty_2;
		}
	}

	void state_bottomdrawer_rusty_2 () {
		text.text = "Welcome to the bottom drawer!\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.desk_rusty_2;
		}
	}

	void state_room2_final () {
		text.text = "You walk into the room. You a lot of SOMETHING. You can hear someone talking through the wall... \n" +
		"It sounds like a woman talking... There is crumbling hole leading outside\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.room2_final_2;
		}
	}

	void state_room2_final_2 () {
		text.text = 
			"Press C to climb through the hole leading outside\n " +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.C)) {
			if (Input.GetKeyDown (KeyCode.C)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		}

		}
}