using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour {

	public int psychCounter;	
	public string decisionOne; //Arrival: Front desk
	public string decisionTwo; //Arrival: Attempting to open the door
	public string decisionThree; //Arrival: Smash or pry glove
	public string decisionFour; //Arrival: Window or Door
	public string decisionFive; //Asylum:Clarissa
	public string decisionSix; //Asylum:Knock, Talk or Kick Hallway Door
	public string decisionSeven; //Dining Hall: What would you do to the doctor?
	public string breakInDecision; //Arrival: How you break into the Asylum
	public string itemOne; //Arrival: Hammer or Wire
	public string itemTwo; //Arrival: KeyPass if found
	public string itemThree; //Asylum: Flashlight
	public string itemFour; //Asylum: Mirror
	public string itemFive; //Dining Hall: Locket
	public string itemSix; //Dining Hall: Knife/Matches
	public string itemSeven; //Dining Hall: Wrench
	public string itemEight; //Dining Hall: Lever


	void Awake () {
	}

	void Start () {
		psychCounter = 0;
		GameObject.DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void AddPsychCounter (int newPsychCounter) {
		psychCounter = newPsychCounter++;
	}
}


