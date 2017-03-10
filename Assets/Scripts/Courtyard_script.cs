using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Courtyard_script : MonoBehaviour {

	public Text text;

	private States myState;
	private enum States {courtyard_1, fountain_1, bench_1, maintenance_1, caf_1, basement_1, tables_1, kitchen_1, cafdoor_1, 
		kitchen_item, courtyard_2, fountain_2, bench_2, maintenance_2, caf_2, basement_2, tables_2, kitchen_2, cafdoor_2, 
		maintenance_inside, monkey_wrench, maintenance_inside_2, courtyard_3, fountain_3, bench_3, maintenance_3, caf_3, 
		basement_3, tables_3, kitchen_3, cafdoor_3,fountain_drain, fountain_item, courtyard_4, fountain_4, bench_4, maintenance_4, caf_4, 
		basement_4, tables_4, kitchen_4, cafdoor_4 }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.courtyard_1) {
			state_courtyard_1 ();
		} else if (myState == States.fountain_1) {
			state_fountain_1 ();
		} else if (myState == States.bench_1) {
			state_bench_1 ();
		} else if (myState == States.maintenance_1) {
			state_maintenance_1 ();
		} else if (myState == States.caf_1) {
			state_caf_1 ();
		} else if (myState == States.basement_1) {
			state_basement_1 ();
		} else if (myState == States.tables_1) {
			state_tables_1 ();
		} else if (myState == States.kitchen_1) {
			state_kitchen_1 ();
		} else if (myState == States.kitchen_1) {
			state_kitchen_item ();
		} else if (myState == States.kitchen_item) {
			state_kitchen_item ();
		} else if (myState == States.fountain_2) {
			state_fountain_2 ();
		} else if (myState == States.bench_2) {
			state_bench_2 ();
		} else if (myState == States.maintenance_2) {
			state_maintenance_2 ();
		} else if (myState == States.caf_2) {
			state_caf_2 ();
		} else if (myState == States.cafdoor_2) {
			state_cafdoor_2 ();
		} else if (myState == States.basement_2) {
			state_basement_2 ();
		} else if (myState == States.tables_2) {
			state_tables_2 ();
		} else if (myState == States.kitchen_2) {
			state_kitchen_2 ();
		} else if (myState == States.cafdoor_1) {
			state_cafdoor_1 ();
		} else if (myState == States.courtyard_2) {
			state_courtyard_2 ();
		} else if (myState == States.courtyard_2) {
			state_courtyard_2 ();
		} else if (myState == States.monkey_wrench) {
			state_monkey_wrench ();
		} else if (myState == States.fountain_3) {
			state_fountain_3 ();
		} else if (myState == States.bench_3) {
			state_bench_3 ();
		} else if (myState == States.maintenance_3) {
			state_maintenance_3 ();
		} else if (myState == States.caf_3) {
			state_caf_3 ();
		} else if (myState == States.basement_3) {
			state_basement_3 ();
		} else if (myState == States.tables_3) {
			state_tables_3 ();
		} else if (myState == States.kitchen_3) {
			state_kitchen_3 ();
		} else if (myState == States.cafdoor_3) {
			state_cafdoor_3 ();
		} else if (myState == States.courtyard_3) {
			state_courtyard_3 ();
		} else if (myState == States.fountain_drain) {
			state_fountain_drain ();
		} else if (myState == States.fountain_4) {
			state_fountain_4 ();
		} else if (myState == States.bench_4) {
			state_bench_4 ();
		} else if (myState == States.maintenance_4) {
			state_maintenance_4 ();
		} else if (myState == States.caf_4) {
			state_caf_4 ();
		} else if (myState == States.basement_4) {
			state_basement_4 ();
		} else if (myState == States.tables_4) {
			state_tables_4 ();
		} else if (myState == States.kitchen_4) {
			state_kitchen_4 ();
		} else if (myState == States.cafdoor_4) {
			state_cafdoor_4 ();
		} else if (myState == States.courtyard_4) {
			state_courtyard_4 ();
		} else if (myState == States.maintenance_inside) {
			state_maintenance_inside ();
		} else if (myState == States.fountain_item) {
			state_fountain_item ();
		} 
	}

	void state_courtyard_1 () {
		text.text = "Welcome to the courtyard\n\n" +
		"Press F to check ot the Fountain\n" +
		"Press B to check out the Bench\n" +
		"Press M to check out Maintenence\n" +
		"Press C to check out Cafeteria";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.fountain_1;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bench_1;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.maintenance_1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.caf_1;
		}
	}
		

	void state_fountain_1 () {
		text.text = "fountain 1\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_1;
		}
	}

	void state_bench_1 () {
		text.text = "bench 1\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_1;
		}
	}

	void state_maintenance_1 () {
		text.text = "maintenance 1\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_1;
		}
	}

	void state_caf_1 () {
		text.text = "caf 1\n\n" +
			"Press B to check ot the Basement\n" +
			"Press T to check out the Tables\n" +
			"Press K to check out Kitchen\n" +
			"Press C to check out the Cafeteria Door\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.basement_1;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.tables_1;
		} else if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.kitchen_1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cafdoor_1;
		}
	}

	void state_basement_1 () {
		text.text = "basment 1";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_1;
		}
	}
		

	void state_tables_1 () {
		text.text = "tables 1";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_1;
		}
	}

	void state_cafdoor_1 () {
		text.text = "You see what's blocking the door. It ain't pretty";
		//can place psycho even here
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_1;
		}
	}

	void state_kitchen_1 () {
		text.text = "kitchen 1 there is item\n\n" +
			"Press G to Grab item\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_1;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.kitchen_item;
		}
	}

	void state_kitchen_item () {
		text.text = "You grab the item\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_2;
		}
	}

	void state_courtyard_2 () {
		text.text = "Welcome to the courtyard\n\n" +
			"Press F to check ot the Fountain\n" +
			"Press B to check out the Bench\n" +
			"Press M to check out Maintenence\n" +
			"Press C to check out Cafeteria";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.fountain_2;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bench_2;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.maintenance_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.caf_2;
		}
	}


	void state_fountain_2 () {
		text.text = "fountain 2\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_2;
		}
	}

	void state_bench_2 () {
		text.text = "bench 2\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_2;
		}
	}

	void state_caf_2 () {
		text.text = "caf 2\n\n" +
			"Press B to check ot the Basement\n" +
			"Press T to check out the Tables\n" +
			"Press K to check out Kitchen\n" +
			"Press C to check out the Cafeteria Door\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.basement_2;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.tables_2;
		} else if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.kitchen_2;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cafdoor_2;
		}
	}

	void state_basement_2 () {
		text.text = "basment 2";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_2;
		}
	}


	void state_tables_2 () {
		text.text = "tables 2";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_2;
		}
	}

	void state_cafdoor_2 () {
		text.text = "You see what's blocking the door. It ain't pretty";
		//can place psycho even here
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_2;
		}
	}

	void state_kitchen_2 () {
		text.text = "kitchen 2\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_2;
		}
	}

	void state_maintenance_2 () {
		text.text = "maintenance 2 break the lock with item\n\n" +
			"Pres B to Break lock\n" +
			"Press R to return\n";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_2;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.maintenance_inside;
		}
	}

	void state_maintenance_inside () {
		text.text = "You are inside the maintenance room.\n\n" +
		"Press P to pick up monkey wrench";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.monkey_wrench;
		}
	}

	void state_monkey_wrench () {
		text.text = "You picked up the monkey wrench\n\n" +
		"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_3;
		}
	}

	void state_courtyard_3 () {
		text.text = "Welcome to the courtyard 4\n\n" +
			"Press F to check ot the Fountain\n" +
			"Press B to check out the Bench\n" +
			"Press M to check out Maintenence\n" +
			"Press C to check out Cafeteria";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.fountain_3;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bench_3;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.maintenance_3;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.caf_3;
		}
	}

	void state_bench_3 () {
		text.text = "bench 3\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_3;
		}
	}

	void state_caf_3 () {
		text.text = "caf 3\n\n" +
			"Press B to check ot the Basement\n" +
			"Press T to check out the Tables\n" +
			"Press K to check out Kitchen\n" +
			"Press C to check out the Cafeteria Door\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.basement_3;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.tables_3;
		} else if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.kitchen_3;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_3;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cafdoor_3;
		}
	}

	void state_basement_3 () {
		text.text = "basment 3";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_3;
		}
	}
		
	void state_tables_3 () {
		text.text = "tables 3";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_3;
		}
	}

	void state_cafdoor_3 () {
		text.text = "You see what's blocking the door. It ain't pretty";
		//can place psycho even here
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_3;
		}
	}

	void state_kitchen_3 () {
		text.text = "kitchen 3\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_3;
		}
	}

	void state_maintenance_3 () {
		text.text = "maintenance 3\n\n" +
			"Press R to return\n";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_3;
		} 
	}

	void state_fountain_3 () {
		text.text = "fountain 3\n\n" +
			"Press U to use monkey wrench" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.fountain_drain;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_3;
		}
	}

	void state_fountain_drain () {
		text.text = "fountain drain you find an item\n\n" +
			"Press P to Pickup Item\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.fountain_item;
		}
	}

	void state_fountain_item () {
		text.text = "You pick up item\n\n" +
			"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.courtyard_4;
		}
	}

		void state_courtyard_4 () {
			text.text = "Welcome to the courtyard 4\n\n" +
				"Press F to check ot the Fountain\n" +
				"Press B to check out the Bench\n" +
				"Press M to check out Maintenence\n" +
				"Press C to check out Cafeteria";

			if (Input.GetKeyDown (KeyCode.F)) {
				myState = States.fountain_4;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.bench_4;
			} else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.maintenance_4;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.caf_4;
			}
		}

		void state_bench_4 () {
			text.text = "bench 4\n\n" +
				"Press R to return";

			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard_4;
			}
		}

		void state_caf_4 () {
			text.text = "caf 2\n\n" +
				"Press B to check ot the Basement\n" +
				"Press T to check out the Tables\n" +
				"Press K to check out Kitchen\n" +
				"Press C to check out the Cafeteria Door\n" +
				"Press R to return";

			if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.basement_4;
			} else if (Input.GetKeyDown (KeyCode.T)) {
				myState = States.tables_4;
			} else if (Input.GetKeyDown (KeyCode.K)) {
				myState = States.kitchen_4;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard_4;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.cafdoor_4;
			}
		}

		void state_tables_4 () {
			text.text = "tables 4";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.caf_4;
			}
		}

		void state_cafdoor_4 () {
			text.text = "You see what's blocking the door. It ain't pretty";
			//can place psycho even here
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.caf_4;
			}
		}

		void state_kitchen_4 () {
			text.text = "kitchen 4\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.caf_4;
			}
		}

		void state_maintenance_4 () {
			text.text = "maintenance 4 break the lock with item\n\n" +
				"Press R to return\n";

			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard_4;
			} 
		}

		void state_fountain_4 () {
			text.text = "fountain 4\n\n" +
				"Press R to return";

			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard_4;
			} 
		}

	void state_basement_4 () {
		text.text = "basment 4 use Item to open basement door\n\n" +
			"Press O to Open basment door\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.caf_4;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
