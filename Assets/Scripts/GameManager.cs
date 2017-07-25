using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject dad;

	public GameObject playerDialog;
	public GameObject dadDialog;
	Text playerText;
	Text dadText;
	
	public static bool isCutscene = true;
	public static bool canMove = false;
	public static bool endGame = false;

	public float textHeight = 2f; //used to set how far above the characters their dialog appears


	void Start() {
		dadText = dadDialog.GetComponent<Text>();
		playerText = playerDialog.GetComponent<Text>();
		StartCoroutine( "Conversation" );
	}

	void FixedUpdate() {
		// Makes text appear above dad's head:
		dadDialog.transform.position = Camera.main.WorldToScreenPoint( dad.transform.position )
									 + new Vector3( 0f, textHeight, 0f );
	}

	private bool DialogChoice() {
		// The choice is a LIE! >:D
		if ( Input.GetKeyDown( KeyCode.Alpha1 )
		  || Input.GetKeyDown( KeyCode.Alpha2 )
		  || Input.GetKeyDown( KeyCode.Alpha3 )) {
			return true;
		} else {
			return false;
		}
	}

	IEnumerator Conversation() {
		playerText.text = "";
		dadText.text = "";
		int index = 0; //used to keep track of dialog

		//yield return new WaitForSeconds(5f);
		isCutscene = false;

		while ( index < Dialog.dadDialog.Length ) {

			float textDelay = 2f + ( Dialog.dadDialog[index].Length * 0.036f ); //makes text delay vary based on length of dialog

			playerText.text = Dialog.playerDialog[index];
			dadText.text = Dialog.dadDialog[index];

			// If dad has nothing to say, wait for player input:
			if ( Dialog.dadDialog[index] == "" ) {
				yield return new WaitUntil( DialogChoice );
			} else {
				yield return new WaitForSeconds( textDelay );
			}

			// Prevents dad from continuing to speak if player is too far away:
			if ( !WaypointMovement.isWaiting ) {
				index++;
			}
		}
	}

}