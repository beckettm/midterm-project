using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour {

	public GameObject player;
	public bool canWaitForPlayer;

	public Transform[] waypointList;
	public int currentWaypoint = 0;
	public float moveSpeed = 4f;
	public float stopDistance; //the distance at which dad will stop to wait for the player

	Transform targetWaypoint;


	void Update() {
		// Check if this has somewere to walk:
		if ( currentWaypoint < this.waypointList.Length ) {
			if ( targetWaypoint == null ) {
				targetWaypoint = waypointList[ currentWaypoint ];
			}

			// If player is too far away, this will stop and wait, else it'll move:
			if ( ( transform.position - player.transform.position ).sqrMagnitude > ( stopDistance * stopDistance ) && canWaitForPlayer ) { //uses square roots to take up less processing power
				TurnToFacePlayer();
			} else {
				Move();
			}
		}
	}

	void Move() {
		// Rotate towards target waypoint:
		transform.forward = Vector3.RotateTowards( transform.forward, targetWaypoint.position - transform.position, moveSpeed * Time.deltaTime, 0.0f );

		// Move towards target waypoint:
		transform.position = Vector3.MoveTowards( transform.position, targetWaypoint.position, moveSpeed * Time.deltaTime );

		if ( transform.position == targetWaypoint.position ) {
			currentWaypoint++;
			targetWaypoint = waypointList[ currentWaypoint ];
		}
	}

	void TurnToFacePlayer() {
		Vector3 lookDir = player.transform.position - transform.position;
		lookDir.y = 0f;
		transform.rotation = Quaternion.LookRotation(lookDir, Vector3.up);
	}
}