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
		StartCoroutine( "Chat" );
	}

	void Update() {
		dadDialog.transform.position = Camera.main.WorldToScreenPoint( dad.transform.position )
									+ new Vector3( 0f, textHeight, 0f ); //to make text appear above dad's head
	}

//	void TurnToFacePlayer(GameObject go) {
//		Vector3 lookDir = player.transform.position - go.transform.position;
//		lookDir.y = 0f;
//		go.transform.rotation = Quaternion.LookRotation(lookDir, Vector3.up);
//	}


	private bool DialogChoice() {
		if ( Input.GetKeyDown( KeyCode.Alpha1 )
		  || Input.GetKeyDown( KeyCode.Alpha2 )
		  || Input.GetKeyDown( KeyCode.Alpha3 )) {
			return true;
		} else {
			return false;
		}
	}

	IEnumerator Chat() {
		playerText.text = "";
		dadText.text = "";

		yield return new WaitForSeconds( 1.5f );
		dadText.text = "I AM MOVING ALONG SET WAYPOINTS";

		yield return new WaitForSeconds( 3f );
		dadText.text = "";
		playerText.text = "[1] These are dialog options.\n" +
						  "[2] Choose one.\n" +
						  "[3] With the number keys.";
		yield return new WaitUntil( DialogChoice );
		playerText.text = "";
		dadText.text = "THIS IS A TEST";

		yield return new WaitForSeconds( 3f );
		dadText.text = "";
		playerText.text = "[1] That's hella meta.\n" +
						  "[2] Are you okay?\n" +
						  "[3] THIS IS A TEST";

		yield return new WaitUntil( DialogChoice );
		playerText.text = "";
		dadText.text = "The prototype is now over!";

		yield return new WaitForSeconds( 2.5f );
		dadText.text = "";
	}
}