using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundChange : MonoBehaviour {


	public Sprite sprite1;
	public Sprite sprite2;

	private SpriteRenderer spriteRenderer;

	public bool CheckState;


	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (spriteRenderer.sprite == null) {
			spriteRenderer.sprite = sprite1;
		}
		CheckState = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (CheckState) {
			if (GameObject.Find ("Text").GetComponent<Asylum_script> ().myState == Asylum_script.States.room4) {
				FlipBackground ();
	
				CheckState = false;
			}
		} 
	}

	void FlipBackground () {
		if (spriteRenderer.sprite == sprite1) {
			spriteRenderer.sprite = sprite2;
			}
		}
	}
