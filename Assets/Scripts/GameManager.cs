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
	
	public static bool isIntro = true;
	public static bool canMove = false;
	public static bool endGame = false;

	public float textHeight = 2f; //used to set how far above the characters their dialog appears


	void Start() {
		dadText = dadDialog.GetComponent<Text>();
		playerText = playerDialog.GetComponent<Text>();
		StartCoroutine( "Conversation" );
	}

	void Update() {
		dadDialog.transform.position = Camera.main.WorldToScreenPoint( dad.transform.position )
									 + new Vector3( 0f, textHeight, 0f ); //to make text appear above dad's head
	}

	private bool DialogChoice() {
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

		for ( int i = 0; i < Dialog.dadDialog.Length; i++ ) {

			float textDelay = 2f + ( Dialog.dadDialog[i].Length * 0.036f ); //makes text delay vary based on length of dialog

			playerText.text = Dialog.playerDialog[i];
			dadText.text = Dialog.dadDialog[i];

			// If dad has nothing to say, wait for player input:
			if ( Dialog.dadDialog[i] == "" ) {
				yield return new WaitUntil(DialogChoice);
			} else {
				yield return new WaitForSeconds( textDelay );
			}
		}

	}
}