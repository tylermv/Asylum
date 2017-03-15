using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Basement_script : MonoBehaviour {
	public Text text;

	private States myState;
	private enum States {basement_1, boiler_1, storage_1, morgue_1, workshop_1, power_1, storage_item, 
		basement_2, boiler_2, storage_2, morgue_2, workshop_2, power_2, workshop_inside,
		basement_3, boiler_3, storage_3, morgue_3, workshop_3, power_3, morgue_inside, 
		drawer_1, drawer_2, drawer_3, drawer_4, drawer_5, 
		basement_4, boiler_4, storage_4, morgue_4, workshop_4, power_4,
		morgue_puzzle, drawer_1_puzzle, drawer_2_puzzle, drawer_3_puzzle, drawer_4_puzzle, drawer_5_puzzle, 
		morgue_puzzle_2, drawer_1_puzzle_2, drawer_2_puzzle_2, drawer_3_puzzle_2, drawer_4_puzzle_2, drawer_5_puzzle_2,
		morgue_puzzle_3, drawer_1_puzzle_3, drawer_2_puzzle_3, drawer_3_puzzle_3, drawer_4_puzzle_3, drawer_5_puzzle_3,
		morgue_puzzle_4, drawer_1_puzzle_4, drawer_2_puzzle_4, drawer_3_puzzle_4, drawer_4_puzzle_4, drawer_5_puzzle_4,
		basement_5, boiler_5, storage_5, morgue_5, workshop_5, power_5, morgue_puzzle_complete, morgue_puzzle_complete_2, 
		boiler_corpse, boiler_corpse_2 , basement_6, boiler_6, storage_6, morgue_6, workshop_6, power_6,
		power_on, end_of_basement}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.basement_1) {
			state_basement_1 ();
		} else if (myState == States.boiler_1) {
			state_boiler_1 ();
		} else if (myState == States.storage_1) {
			state_storage_1 ();
		} else if (myState == States.morgue_1) {
			state_morgue_1 ();
		} else if (myState == States.workshop_1) {
			state_workshop_1 ();
		} else if (myState == States.power_1) {
			state_power_1 ();
		} else if (myState == States.storage_item) {
			state_storage_item ();
		} else if (myState == States.basement_2) {
			state_basement_2 ();
		} else if (myState == States.boiler_2) {
			state_boiler_2 ();
		} else if (myState == States.storage_2) {
			state_storage_2 ();
		} else if (myState == States.morgue_2) {
			state_morgue_2 ();
		} else if (myState == States.workshop_2) {
			state_workshop_2 ();
		} else if (myState == States.power_2) {
			state_power_2 ();
		} else if (myState == States.workshop_inside) {
			state_workshop_inside ();
		} else if (myState == States.basement_3) {
			state_basement_3 ();
		} else if (myState == States.boiler_3) {
			state_boiler_3 ();
		} else if (myState == States.storage_3) {
			state_storage_3 ();
		} else if (myState == States.morgue_3) {
			state_morgue_3 ();
		} else if (myState == States.workshop_3) {
			state_workshop_3 ();
		} else if (myState == States.power_3) {
			state_power_3 ();
		} else if (myState == States.morgue_inside) {
			state_morgue_inside ();
		} else if (myState == States.drawer_1) {
			state_drawer_1 ();
		} else if (myState == States.drawer_2) {
			state_drawer_2 ();
		} else if (myState == States.drawer_3) {
			state_drawer_3 ();
		} else if (myState == States.drawer_4) {
			state_drawer_4 ();
		} else if (myState == States.drawer_5) {
			state_drawer_5 ();
		} else if (myState == States.basement_4) {
			state_basement_4 ();
		} else if (myState == States.boiler_4) {
			state_boiler_4 ();
		} else if (myState == States.storage_4) {
			state_storage_4 ();
		} else if (myState == States.workshop_4) {
			state_workshop_4 ();
		} else if (myState == States.power_4) {
			state_power_4 ();
		} else if (myState == States.morgue_puzzle) {
			state_morgue_puzzle ();
		} else if (myState == States.drawer_1_puzzle) {
			state_drawer_1_puzzle ();
		} else if (myState == States.drawer_2_puzzle) {
			state_drawer_2_puzzle ();
		} else if (myState == States.drawer_3_puzzle) {
			state_drawer_3_puzzle ();
		} else if (myState == States.drawer_4_puzzle) {
			state_drawer_4_puzzle ();
		} else if (myState == States.drawer_5_puzzle) {
			state_drawer_5_puzzle ();
		} else if (myState == States.morgue_puzzle_2) {
			state_morgue_puzzle_2 ();
		} else if (myState == States.drawer_1_puzzle_2) {
			state_drawer_1_puzzle_2 ();
		} else if (myState == States.drawer_2_puzzle_2) {
			state_drawer_2_puzzle_2 ();
		} else if (myState == States.drawer_3_puzzle_2) {
			state_drawer_3_puzzle_2 ();
		} else if (myState == States.drawer_4_puzzle_2) {
			state_drawer_4_puzzle_2 ();
		} else if (myState == States.drawer_5_puzzle_2) {
			state_drawer_5_puzzle_2 ();
		} else if (myState == States.morgue_puzzle_3) {
			state_morgue_puzzle_3 ();
		} else if (myState == States.drawer_1_puzzle_3) {
			state_drawer_1_puzzle_3 ();
		} else if (myState == States.drawer_2_puzzle_3) {
			state_drawer_2_puzzle_3 ();
		} else if (myState == States.drawer_3_puzzle_3) {
			state_drawer_3_puzzle_3 ();
		} else if (myState == States.drawer_4_puzzle_3) {
			state_drawer_4_puzzle_3 ();
		} else if (myState == States.drawer_5_puzzle_3) {
			state_drawer_5_puzzle_3 ();
		} else if (myState == States.morgue_puzzle_complete) {
			state_morgue_puzzle_complete ();
		} else if (myState == States.morgue_puzzle_complete_2) {
			state_morgue_puzzle_complete_2 ();
		} else if (myState == States.morgue_puzzle_4) {
			state_morgue_puzzle_4 ();
		} else if (myState == States.drawer_1_puzzle_4) {
			state_drawer_1_puzzle_4 ();
		} else if (myState == States.drawer_2_puzzle_4) {
			state_drawer_2_puzzle_4 ();
		} else if (myState == States.drawer_3_puzzle_4) {
			state_drawer_3_puzzle_4 ();
		} else if (myState == States.drawer_4_puzzle_4) {
			state_drawer_4_puzzle_4 ();
		} else if (myState == States.drawer_5_puzzle_4) {
			state_drawer_5_puzzle_4 ();
		} else if (myState == States.basement_5) {
			state_basement_5 ();
		} else if (myState == States.boiler_5) {
			state_boiler_5 ();
		} else if (myState == States.storage_5) {
			state_storage_5 ();
		} else if (myState == States.workshop_5) {
			state_workshop_5 ();
		} else if (myState == States.power_5) {
			state_power_5 ();
		} else if (myState == States.morgue_5) {
			state_morgue_5 ();
		} else if (myState == States.boiler_corpse) {
			state_boiler_corpse ();
		} else if (myState == States.boiler_corpse_2) {
			state_boiler_corpse_2 ();
		} else if (myState == States.basement_6) {
			state_basement_6 ();
		} else if (myState == States.boiler_6) {
			state_boiler_6 ();
		} else if (myState == States.storage_6) {
			state_storage_6 ();
		} else if (myState == States.workshop_6) {
			state_workshop_6 ();
		} else if (myState == States.power_6) {
			state_power_6 ();
		} else if (myState == States.morgue_6) {
			state_morgue_6 ();
		} else if (myState == States.power_on) {
			state_power_on ();
		} else if (myState == States.end_of_basement) {
			state_end_of_basement ();
		}
	}

	void state_basement_1 () {
		text.text = "basement 1\n\n" +
			"Press P to check out the Power room\n" + 
			"Press B to check out the Boiler room\n" + 
			"Press M to check out the Morgue\n" + 
			"Press W to check out the Workshop\n" +
			"Press S to check out the Storage room\n";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boiler_1;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.power_1;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.workshop_1;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.storage_1;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.morgue_1;
		}

	}

	void state_boiler_1 () {
		text.text = "boiler 1\n\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_1;
		}
	}

	void state_morgue_1 () {
		text.text = "morgue 1\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_1;
		}
	}

	void state_workshop_1 () {
		text.text = "workshop 1\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_1;
		}
	}

	void state_power_1 () {
		text.text = "power 1\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_1;
		}
	}

	void state_storage_1 () {
		text.text = "storage 1\n" +
			"You find item\n"+
			"Press P to pickup item";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.storage_item;
		}
	}

	void state_storage_item () {
		text.text = "storage item\n" +
			"You pick up item\n"+
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_basement_2 () {
		text.text = "basement 2\n\n" +
			"Press P to check out the Power room\n" + 
			"Press B to check out the Boiler room\n" + 
			"Press M to check out the Morgue\n" + 
			"Press W to check out the Workshop\n" +
			"Press S to check out the Storage room\n";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boiler_2;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.power_2;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.workshop_2;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.storage_2;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.morgue_2;
		}

	}

	void state_boiler_2 () {
		text.text = "boiler 2\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_morgue_2 () {
		text.text = "morgue 2\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_power_2 () {
		text.text = "power 2\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_storage_2 () {
		text.text = "storage 2\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_workshop_2 () {
		text.text = "Use item on workshop 2?\n\n" +
			"Press U to Use item\n" + 
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.workshop_inside;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_workshop_inside () {
		text.text = "You explore a bit. You pick up the item\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_3;
		}
	}

		void state_basement_3 () {
			text.text = "basement 3\n\n" +
				"Press P to check out the Power room\n" + 
				"Press B to check out the Boiler room\n" + 
				"Press M to check out the Morgue\n" + 
				"Press W to check out the Workshop\n" +
				"Press S to check out the Storage room\n";

			if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.boiler_3;
			} else if (Input.GetKeyDown (KeyCode.P)) {
				myState = States.power_3;
			} else if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.workshop_3;
			} else if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.storage_3;
			} else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.morgue_3;
			}

		}

		void state_boiler_3 () {
			text.text = "boiler 3\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.basement_3;
			}
		}

		void state_power_3 () {
			text.text = "power 3\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.basement_3;
			}
		}

		void state_storage_3 () {
			text.text = "storage 3\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.basement_3;
			}
		}

		void state_workshop_3 () {
			text.text = "workshop 3\n\n" +
				"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.basement_3;
		}
	}
		void state_morgue_3 () {
			text.text = "morgue 3 use item to open\n\n" +
				"Press U item to Open" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.U)) {
				myState = States.morgue_inside;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_3;
		} 
	}
		void state_morgue_inside () {
		text.text = "Press A to check out Drawer 1\n" + 
				"Press B to check out Drawer 2\n" + 
				"Press C to check out Drawer 3\n" + 
				"Press D to check out Drawer 4\n" + 
				"Press E to check out Drawer 5\n" + 
				"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.basement_4;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.drawer_1;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.drawer_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.drawer_3;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.drawer_4;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.drawer_5;
			} 
		}

	void state_drawer_1 () {
		text.text = "drawer_1 is locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	}

	void state_drawer_2 () {
		text.text = "drawer_2 is locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	}

	void state_drawer_3 () {
		text.text = "drawer_3 is locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	} 

	void state_drawer_4 () {
		text.text = " You open drawer_4. You hear a click from another drawer.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.morgue_puzzle;
		} 
	}

	void state_drawer_5 () {
		text.text = "drawer_5 is locked.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	}

	void state_basement_4 () {
		text.text = "basement 4\n\n" +
			"Press P to check out the Power room\n" + 
			"Press B to check out the Boiler room\n" + 
			"Press M to check out the Morgue\n" + 
			"Press W to check out the Workshop\n" +
			"Press S to check out the Storage room\n";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boiler_4;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.power_4;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.workshop_4;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.storage_4;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.morgue_4;
		}
	}

	void state_boiler_4 () {
		text.text = "boiler 4\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		}
	}

	void state_power_4 () {
		text.text = "power 4\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		}
	}

	void state_storage_4 () {
		text.text = "storage 4\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		}
	}

	void state_workshop_4 () {
		text.text = "workshop 4\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.basement_4;
		}
	}
	void state_morgue_puzzle () {
		text.text = "Press A to check out Drawer 1\n" + 
			"Press B to check out Drawer 2\n" + 
			"Press C to check out Drawer 3\n" + 
			"Press D to check out Drawer 4\n" + 
			"Press E to check out Drawer 5\n" + 
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.drawer_1_puzzle;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.drawer_2_puzzle;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.drawer_3_puzzle;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.drawer_4_puzzle;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.drawer_5_puzzle;
		} 
	}

	void state_drawer_1_puzzle () {
		text.text = "drawer_1 is locked. Door 4 slams shut\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	}

	void state_drawer_2_puzzle () {
		text.text = "drawer_2 opens. You hear a lock from somwhere else.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.morgue_puzzle_2;
		} 
	}

	void state_drawer_3_puzzle () {
		text.text = "drawer_3 is locked. Door 4 slams shut\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	} 

	void state_drawer_4_puzzle () {
		text.text = " There's nothing inside here\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle;
		} 
	}

	void state_drawer_5_puzzle () {
		text.text = "drawer_5 is locked. Door 4 slams shut\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	}

	void state_morgue_puzzle_2 () {
		text.text = "Press A to check out Drawer 1\n" + 
			"Press B to check out Drawer 2\n" + 
			"Press C to check out Drawer 3\n" + 
			"Press D to check out Drawer 4\n" + 
			"Press E to check out Drawer 5\n" + 
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.drawer_1_puzzle_2;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.drawer_2_puzzle_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.drawer_3_puzzle_2;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.drawer_4_puzzle_2;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.drawer_5_puzzle_2;
		} 
	}

	void state_drawer_1_puzzle_2 () {
		text.text = "drawer_1 is locked. Door 4 slams shut\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	}

	void state_drawer_2_puzzle_2 () {
		text.text = "drawer_2 opens. there's something cool inside\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_2;
		} 
	}

	void state_drawer_3_puzzle_2 () {
		text.text = "drawer_3 is locked. Door 4 slams shut\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	} 

	void state_drawer_4_puzzle_2 () {
		text.text = " There's nothing inside here\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_2;
		} 
	}

	void state_drawer_5_puzzle_2 () {
		text.text = "drawer_5 opens. You hear a lock from somehwere else.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.morgue_puzzle_3;
		} 
	}

	void state_morgue_puzzle_3 () {
		text.text = "Press A to check out Drawer 1\n" + 
			"Press B to check out Drawer 2\n" + 
			"Press C to check out Drawer 3\n" + 
			"Press D to check out Drawer 4\n" + 
			"Press E to check out Drawer 5\n" + 
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.drawer_1_puzzle_3;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.drawer_2_puzzle_3;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.drawer_3_puzzle_3;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.drawer_4_puzzle_3;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.drawer_5_puzzle_3;
		} 
	}

	void state_drawer_1_puzzle_3 () {
		text.text = "drawer_1 opens up. You hear a click\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.morgue_puzzle_4;
		} 
	}

	void state_drawer_2_puzzle_3 () {
		text.text = "drawer_2 opens. there's something cool inside\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_3;
		} 
	}

	void state_drawer_3_puzzle_3 () {
		text.text = "drawer_3 is locked. Door 4 slams shut\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_inside;
		} 
	} 

	void state_drawer_4_puzzle_3 () {
		text.text = " There's nothing inside here\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_3;
		} 
	}

	void state_drawer_5_puzzle_3 () {
		text.text = "drawer_5 opens is open. There is nothing there.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_3;
		} 
	}

	void state_morgue_puzzle_4 () {
		text.text = "Press A to check out Drawer 1\n" + 
			"Press B to check out Drawer 2\n" + 
			"Press C to check out Drawer 3\n" + 
			"Press D to check out Drawer 4\n" + 
			"Press E to check out Drawer 5\n" + 
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_4;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.drawer_1_puzzle_4;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.drawer_2_puzzle_4;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.drawer_3_puzzle_4;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.drawer_4_puzzle_4;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.drawer_5_puzzle_4;
		} 
	}

	void state_drawer_1_puzzle_4 () {
		text.text = "drawer_1 is open.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_4;
		} 
	}

	void state_drawer_2_puzzle_4 () {
		text.text = "drawer_2 opens. there's something cool inside\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_4;
		} 
	}

	void state_drawer_3_puzzle_4 () {
		text.text = "drawer_3 opens up!\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_complete;
		} 
	} 

	void state_drawer_4_puzzle_4 () {
		text.text = " There's nothing inside here\n\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_4;
		} 
	}

	void state_drawer_5_puzzle_4 () {
		text.text = "drawer_5 opens is open. There is nothing there.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.morgue_puzzle_4;
		} 
	}

	void state_morgue_puzzle_complete () {
		text.text = "Add narrative\n\n" +
		"Press Space to continue";

		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.morgue_puzzle_complete_2;
		} 
	}

	void state_morgue_puzzle_complete_2 () {
		text.text = "You find a corpse. You take something important\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_5;
		} 
	}

	void state_basement_5 () {
		text.text = "basement 5\n\n" +
			"Press P to check out the Power room\n" + 
			"Press B to check out the Boiler room\n" + 
			"Press M to check out the Morgue\n" + 
			"Press W to check out the Workshop\n" +
			"Press S to check out the Storage room\n";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boiler_5;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.power_5;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.workshop_5;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.storage_5;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.morgue_5;
		}
	}

	void state_morgue_5 () {
		text.text = "morgue 5\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_5;
		}
	}

	void state_power_5 () {
		text.text = "power 5\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_5;
		}
	}

	void state_storage_5 () {
		text.text = "storage 5\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_5;
		}
	}

	void state_workshop_5 () {
		text.text = "workshop 5\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_2;
		}
	}

	void state_boiler_5 () {
		text.text = "Put the corpse in the fire?\n\n" +
			"Press P to Put the corpse in the fire" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_5;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.boiler_corpse;
		}
	}

	void state_boiler_corpse () {
		text.text = "The corpse burns. You think about your past or some narrative peice...\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.boiler_corpse_2;
		}
	}

	void state_boiler_corpse_2 () {
		text.text = "The ashes reveal an item\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.basement_6;
		}
	}
	void state_basement_6 () {
		text.text = "basement 5\n\n" +
			"Press P to check out the Power room\n" + 
			"Press B to check out the Boiler room\n" + 
			"Press M to check out the Morgue\n" + 
			"Press W to check out the Workshop\n" +
			"Press S to check out the Storage room\n";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.boiler_6;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.power_6;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.workshop_6;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.storage_6;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.morgue_6;
		}
	}

	void state_morgue_6 () {
		text.text = "morgue 6\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_6;
		}
	}

	void state_storage_6 () {
		text.text = "storage 6\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_6;
		}
	}

	void state_workshop_6 () {
		text.text = "workshop 6\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_6;
		}
	}

	void state_boiler_6 () {
		text.text = "boiler 6\n\n" +
			"Press P to Put the corpse in the fire" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.basement_6;
		}
	}

	void state_power_6 () {
		text.text = "power 6\n\n" +
			"Press U to use item" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.power_on;
		}
	}

	void state_power_on () {
		text.text = "the power of the Asylum turns on\n\n" +
		"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.end_of_basement;
		}
	}

	void state_end_of_basement () {
		text.text = "Add a reason for them to be forced our of the basement\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
