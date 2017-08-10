using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiningHall_script: MonoBehaviour {
	//editing notes, last stopped after escaping the psych room. Still haven't edited the normal escape.
	public Text text;
	public int psychValue;
	StateController stateController;

	public States myState;
	public enum States {dininghall, dininghall2, //starting scenes
	labCoat, voiceRecorder, decision1, doctorDecision,  //psych decisions
	eatingArea1, backdoor1, kitchens, //dining hall navigation
	chairs1, middle1, bag1,  //eating area navigation
	stove1, cupboards1, drawers1, basement1,  //Kitchen navigation
	courtyard, bench, fountain, shed, statue1, statue2, //courtyard navigation
	takeLocket, //second courtyard navigation after locket
	takeKnife, takeMatches,openCupboard,
	openShed, takeTool, ropeScene,fountainDrain, 
	 }; 

	// Use this for initialization
	void Start () {
		myState = States.dininghall;
		stateController = (StateController)FindObjectOfType(typeof(StateController));
		psychValue = stateController.psychCounter;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.dininghall) {
			state_dininghall ();
		} else if (myState == States.dininghall2) {
			state_dininghall2 ();
		} else if (myState == States.eatingArea1) {
			state_eatingArea1 ();
		} else if (myState == States.kitchens) {
			state_kitchens ();
		} else if (myState == States.backdoor1) {
			state_backdoor1 ();
		} else if (myState == States.courtyard) {
			state_courtyard ();
		} else if (myState == States.shed) {
			state_shed ();
		} else if (myState == States.fountain) {
			state_fountain ();
		} else if (myState == States.labCoat) {
			state_labCoat ();
		} else if (myState == States.cupboards1) {
			state_cupboards1 ();
		} else if (myState == States.drawers1) {
			state_drawers1 ();
		} else if (myState == States.stove1) {
			state_stove1 ();
		} else if (myState == States.takeKnife) {
			state_takeKnife ();
		} else if (myState == States.takeMatches) {
			state_takeMatches ();
		} else if (myState == States.chairs1) {
			state_chairs1 ();
		} else if (myState == States.middle1) {
			state_middle1 ();
		} else if (myState == States.bag1) {
			state_bag1 ();
		} else if (myState == States.statue1) {
			state_statue1 ();
		} else if (myState == States.statue2) {
			state_statue2 ();
		} else if (myState == States.basement1) {
			state_basement1 ();
		} else if (myState == States.takeLocket) {        //TRANSITION #1
			state_takeLocket ();
		} else if (myState == States.openCupboard) { // transition
			state_openCupboard ();
		} else if (myState == States.ropeScene) {
			state_ropeScene ();
		} else if (myState == States.openShed) {
			state_openShed ();
		} else if (myState == States.takeTool) { //transition
			state_takeTool ();
		} else if (myState == States.doctorDecision) {
			state_doctorDecision ();
		} else if (myState == States.decision1) {
			state_decision1 ();
		} else if (myState == States.bench) {
			state_bench ();
		} else if (myState == States.fountainDrain) {
			state_fountainDrain ();
		}
	}

		void state_dininghall () {
		text.text = "You venture into the Dining Hall.\n\n" +
		"You look down at the bottom of the door. It looks like someone's lab coat next to a dried up pool of blood\n" +
			"Was there something here blocking the door before? The blood looks like it trails off further into the diniing room. \n\n" +
		"Press Space to Continue";
			if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.labCoat;
			} 
		}

	void state_labCoat () {
		text.text = "You check through the pockets and of the lab coat to find a wallet. According the drivers license, the wallet belonged to a Dr. Cole. " +
			"You find an Asylum pass, he must've worked here." +
			"You find a voice recorder... You press play.\n\n" +
		"This is Dr. Cole, it's March 31st, 2017 and the time is now 10:38 pm. This is the last day of experimentation for me. Dr. Fulton has grown... obsessed." +
		"At first, I was one board considering what had happened to Ms. Sheppard. It's time for me to move on but I fear for how he'll react... Oh no NOOOOO...\n" +
		"The recording cuts out there.\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.decision1;
		}
	}

	void state_decision1 () {
		text.text = "If this Dr. Cole had anything to do with your parents, well, what would you do?\n\n" +
			"Press A for You would do nothing. It sounds like he got what he deserved.\n" +
			"Press B for You would kill him.\n" +
			"Press C for you'd beat him to an inch of his life";
		if (Input.GetKeyDown (KeyCode.A)) {
			stateController.decisionSeven = "leaveHim";
			myState = States.doctorDecision;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			stateController.decisionSeven = "kill";
			myState = States.doctorDecision;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			stateController.decisionSeven = "beat";
			myState = States.doctorDecision;
		}
	}

	void state_doctorDecision () {
		if (stateController.decisionSeven == "leaveHim") { 
			text.text = "You'd leave him. From the sound of the recording and the blood around his trench coat, he got what he deserved.\n\n" +
				"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.dininghall2;
			}
		} else if (stateController.decisionSeven == "kill") {
			stateController.AddPsychCounter (psychValue + 5);
			text.text = "You'd kill him for whatever involvement he had in the death of your parents.\n\n" +
				"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.dininghall2;
			}
		} else if (stateController.decisionSeven == "beat") {
			stateController.AddPsychCounter (psychValue + 3);
			text.text = "You'd beat him to an inch of his life for whatever part he had to play\n\n" +
				"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.dininghall2;
			}
		}
	}

	void state_dininghall2 () {
		text.text = " You take a look around the dininghall.\n\n" +
			"To your left are thie kitchens and the trail of dried blood looks like it leads to the tables and chairs in the main hall." +
			" Across the hall is a door.\n" +
			"What do you do?\n\n" +
			"Press A to check out the kitchens.\n" +
			"Press B to follow what looks like dried blood\n" +
			"Press C to take go to the back door\n" +
			"Press D to check the lab coat";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.kitchens;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.eatingArea1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.backdoor1;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.labCoat;
		}
	}

	void state_kitchens () {
		text.text = "You walk into the kitchens. It's a pretty clean facility with stainless steel tables and cupboards. There's a stove to one side of you and a and some drawers to the other side.\n" +
			"At the back is the door to the basement. What do you do?\n\n" +
			"Press S to look at the stove\n" +
			"Press D to check the drawers\n" +
			"Press C to search through the Cupboards.\n" +
			"Press B to try the door to the basement\n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.drawers1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.cupboards1;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stove1;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.dininghall2;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.basement1;
		}
	}

	void state_basement1 () {
		if (stateController.itemEight == "lever") {
			text.text = "You walk over to the basement door. And push the lever into place.\n\n" +
			" Press O to open the door\n" +
			"Press R to keep exploring";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.kitchens;
			} else if (Input.GetKeyDown (KeyCode.O)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		} else {
			text.text = "You walk over to the basement door. You look to push the lever that opens the door but notice" +
			" the lever is missing.\n\n" +
			"Of course it is.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.kitchens;
			}
		}
	}

	void state_drawers1 () {
		text.text = "You rummage through the drawers to find some cutlery. There are forks and spoons... but no knives." +
			" Makes sense... in an Asylum\n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.kitchens;
		}
	}

	void state_cupboards1 () {
		if (stateController.itemSix == "matches") {
			stateController.itemFive = null;
			text.text = "You take a look in the cupbaords. This is where they locked away dangerous stuff from the patients.\n\n" +
				"Press R to keep exploring";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.kitchens;
			}
		}
		else if (stateController.itemFive == "locket") {
			text.text = "You try to open the cupboards. They're locked. You rummage through you pocket and pull out the key that was in the locket.\n\n" +
			"Press K to use the key\n\n" +
			"Press R to keep exploring";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.kitchens;
			} else if (Input.GetKeyDown (KeyCode.K)) {
				myState = States.openCupboard;
			}
		} else {
			text.text = "You try to open the cupboards. They're locked. It looks like it takes a key.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.kitchens;
			}
		}
	}

	void state_stove1 () {
		text.text = "You take a look at the stove. Looks like a gas stove... but you don't see any matches.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.kitchens;
		}
	}

	void state_eatingArea1 () 	{
		text.text = "You venture into the eating area.\n\n" +
			"There you see a number of tables and chairs. You see some of the chairs have been knocked over. That seems weird. There's also something interesting in " +
			"middle of the room but you can't quite make it out. What do you do?\n\n" +
			"Press C to investigate the chairs\n" +
			"Press M to investigate the middle of the room\n\n" +
			"Press R to Return";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.chairs1;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.middle1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.dininghall2;
		}
	}

	void state_chairs1 () { //this should be psych controlled
		text.text = "You walk over to the knocked over chairs. \n\nThe floor is blood stained. It looks like there was a struggle here." +
			"You notice there's a bloody handprint on the table. You follow it from table to table until you find what looks like where the struggle ended." +
			"It looks like someone was dragged back to the door.\n\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.eatingArea1;
		}
	}

	void state_middle1 () {
		text.text = "You walk into the middle of the eating area. You find a garbage bag. What do you do?\n\n" +
			"Press O to open the bag\n" +
			"Press R to return";
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.bag1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.eatingArea1;
		}
	}

	void state_bag1 () {
		if (stateController.psychCounter <= 25) {
			text.text = "You open the bag.\n\n" +
				"Inside you find a womans dress, white and bloog stained. A man's dress shirt, white and bloog stained." +
				"There's a bouquet of whilted flowers, a gold pendant necklace and a silver watch with black straps.\n\n" +
				"Strange. What happened here?\n\n" +
				"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.dininghall2;
			}
		} else {
			text.text = "You open the bag.\n\n" +
			"Inside you find patient clothes, an old toothbrush and some flat shoes.\n" +
			"They're filthy with what looks like dirt and dried blood. It looks like someone had sharpened the toothbrush into a point. Did a patient do this?\n" +
			"You check the clothes for a name. It reads Frank.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.dininghall2;
			}
		}
	}

	void state_backdoor1 () {
		text.text = "You walk past the kitchen and the dininghall to the back door. It looks like it leads out to a courtyard.\n\n" +
			"Press O to Open the door\n" +
			"Press R to return";
		if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.courtyard;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.dininghall2;
		}
	}	

	void state_courtyard () {
			text.text = "You walk outside.\n\nThe cold air hits you. You feel the grips of stress and anxiety release itself for just a moment\n" +
			"You look around you. There's a big fountain in the middle of the courtayrd. To your left is a bench and seating area surrounded by statutes on either side of it" +
			" Past the fountain is a utility shed. \nWhat do you do?\n\n" +
			"Press F to check out the Fountain\n" +
			"Press B to check out the Bench\n" +
			"Press S to check out the Shed\n\n" +
			"Press R to Return to the Dining Hall";

		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.bench;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.fountain;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.shed;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.dininghall2;
		}
	}

	void state_bench () {
		text.text = "You walk over to the bench.\n\nIt's surrounded by a bush of flowers that you don't recognize. On either side is a beautiful stone statue." +
		"One is a man, muscular and naked, holding is hand out to the woman. The woman, who is also nude, remains shy. \n" +
		"You look down at the bench and notice there's a plaque. It reads: In Memory of Ms. Sheppard who was loved by all.\n\n" +
		"Press A to inspect the statue of the man\n" +
		"Press B to inspect the statue of the woman\n\n" +
			"Press R to return";

		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.courtyard;
		} else if (Input.GetKeyDown(KeyCode.A)) {
			myState = States.statue1;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.statue2;
		}
	}

	void state_statue1 () {
		if (stateController.itemFive == "locket") {
			text.text = "You look at the statue of a man. He looks muscular and strong. We's wearing nothing." +
			" He's frozen in time holding his hand out to the statue of the woman. He looks worried.\n\n" +
			"Press B to inspect the statue of the female\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.statue2;
			}
		} else {
			text.text = "You look at the statue of a man. He looks muscular and strong. We's wearing nothing." +
			"He's frozen in time holding his hand out to the statue of the woman. He looks worried.\n\n" +
			"Press B to inspect the statue of the female\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.statue2;
			}
		}
	}

	void state_statue2 () {
		if (stateController.itemFive == "locket") {
			text.text = "You look at the statue of the woman. She's exposed as well, wearing nothing but a cloth that she holds close to her face" +
			" as it drapes down around her hips. She's frozen in time wondering if she should take his hand. She looks shy but curious.\n\n" +
			"Press A to inspect the statue of the man\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			} else if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.statue1;
			}
		} else {
			text.text = "You look at the statue of the woman. She's exposed as well, wearing nothing but a cloth that she holds close to her face" +
			" as it drapes down around her hips. She's frozen in time wondering if she should take his hand. She looks shy but curious.\n\n" +
			"The glint of something in the moonlight catches your eye. A locket hangs from the statues neck.\n" +
			"Press A to inspect the statue of the man\n" +
			"Press T to take the locket\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			} else if (Input.GetKeyDown (KeyCode.T)) {
				myState = States.takeLocket;
			} else if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.statue1;
			}
		}
	}

	void state_fountain () {
		if (stateController.itemEight == "lever") {
			stateController.itemSeven = null;
			text.text = "You walk over to the fountain.\n\n " +
				"It's beautifully sculpted. You can make out crashing waves and dancing fish carved in stone under the green grassy " +
				"stuff that's grown overtime. At the bottom you can now see the coins left behind. Once wishes now rusty coins. " +
				"Press R to return";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.courtyard;
			}
		}

		if (stateController.itemSeven == "wrench") {
			text.text = "You walk over to the fountain.\n\nIt's beautifully sculpted. You can make out crashing waves and dancing fish carved in stone under the green grassy " +
			"stuff that's grown overtime. The fountain isn't working but it's full of murky water. You can't see to the bottom." +
			"There's a number of valves and levers on the side that look to control the flow of water. But it looks like it needs a tool.\n\n" +
			"Press T to use the tool\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.T)) {
				myState = States.fountainDrain;
			}
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			}
		} else { 
			text.text = "You walk over to the fountain.\n\nIt's beautifully sculpted. You can make out crashing waves and dancing fish carved in stone under the green grassy " +
			"stuff that's grown overtime. The fountain isn't working but it's full of murky water. You can't see to the bottom." +
			"There's a number of valves and levers on the side that look to control the flow of water. But it looks like it needs a tool.\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			}
		}
	}

	void state_shed () { 									//-----------edit this----------------//
		if (stateController.itemSeven == "wrench") {
			text.text = "You look back inside the shed. It's old dark and smells moldy. There's not much else that an help\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			} 
		}	else if (stateController.itemSix == "matches") {
			text.text = "You walk over to the utility shed. You try pulling on the door handle but you see it's tied shut at the handles by an old rope\n\n" +
				"Press M to use the matches\n" +
				"Press R to return";
			if (Input.GetKeyDown(KeyCode.R)) {
				myState = States.courtyard;
			} else if (Input.GetKeyDown(KeyCode.M)) {
				myState = States.ropeScene;
			} 
		} else if (stateController.itemSix == "knife") {
			text.text = "You walk over to the utility shed. You try pulling on the door handle but you see it's tied shut at the handles by an old rope\n\n" +
			"Press K to use the knife\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			} else if (Input.GetKeyDown (KeyCode.K)) {
				myState = States.ropeScene;
			} 
		} else {
			text.text = "You walk over to the utility shed. You try pulling on the door handle but you see it's tied shut at the handles by an old rope\n\n" +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			}
		}
	}
														//-----------Add a creepy scene here------------------

	void state_takeLocket () { 
		stateController.itemFive = "locket";
		text.text = "You grab the locket. You open it up to find a key inside. This could come in handy.\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.courtyard;
		}
	}

	void state_openCupboard () {
		text.text = "You press the key into the lock and turn. You open up the cupboard to find a number of items locked away from the patients.\n" +
		"There are some perscription medications & cleaning chemicals. Beside those are a box of matches, presumably for the stove and the some sharp knives. \nWhat do you take?\n\n" +
		"Press K to take a knife\n" +
		"Press M to take the matches";
		if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.takeKnife;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.takeMatches;
		}
	}
	void state_takeMatches () {
		stateController.itemSix = "matches";
		text.text = "You grab the matches. These could come in handy.\n\n" +
			"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.kitchens;
		}
	}

	void state_takeKnife () {
		stateController.itemSix = "knife";
		text.text = "You take the knife. This could come in handy.\n\n" +
		"Press Space to continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.kitchens;
		}
	}

	void state_ropeScene () {
		if (stateController.itemSix == "matches") {
			text.text = "You light a match and press it to the rope. It lights and snaps open.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				stateController.itemSix = "nullMatches";
				myState = States.openShed;
			}
		} else if (stateController.itemSix == "knife") {
			text.text = "You take your knife and begin cutting the rope. You dig into the rope with your blade and slide back and forth. " +
				"After a little effort, it snaps. \n\n" +
				"Press Space to continue";
			if (Input.GetKeyDown(KeyCode.Space)) {
				stateController.itemSix = "nullKnife";
				myState = States.openShed;
			}
		}
	}

	void state_openShed () { //this should be psych controlled
		if (stateController.itemSeven == "wrench") {
			text.text = "You walk into the old moldy shed..." +
			"Press R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
					myState = States.shed;
			}
		} else {
			text.text = "You open the doors to the shed.\n\n" +
			"The shed looks old and rotted away. It smells moldy and earthy." +
			" A quick look around and there's not much in here. It almost looks like it was cleared out before it was locked up.\n" +
			"There's a single wrench on the work bench.\n\n" +
			"Press W to take the wrench";
			if (Input.GetKeyDown (KeyCode.W)) {
				stateController.itemSeven = "wrench";
				myState = States.takeTool;
			}
		}
	}

	void state_takeTool () {
		if (stateController.itemSeven == "wrench") {
			text.text = "You walk over to the moldy old shed that was tied shut. There's nothing left here.\n\n" +
			"Oress R to return";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.courtyard;
			}
		} else {
			text.text = "You pick up the wrench.\n\n" +
			"Press Space to continue";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.courtyard;
			}
		}
	}

	void state_fountainDrain () {
		text.text = "You put the tool to the pipes and turn. You hear gurgling and burping and in a moment, the fountain drains." +
			"At the bottom under all that muck is a lever.\n\n" +
			"Press P to pickup the lever";
		if (Input.GetKeyDown (KeyCode.P)) {
			stateController.itemEight = "lever";
			myState = States.courtyard;
		}
	}
}