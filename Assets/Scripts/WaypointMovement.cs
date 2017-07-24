using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour {

	/* Waypoint Movement Variables */
	public Transform[] waypointList;
	public int currentWaypoint = 0;
	public float moveSpeed = 4f;

	Transform targetWaypoint;


	/* Player-Tracking Variables */
	public GameObject player;
	public float stopDistance; //the distance at which dad will stop to wait for the player
	public bool canWaitForPlayer;
	private bool willMove = true;

	float distToPlayerSqr;
	float stopDistSqr;


	void Update() {
		// Calculates squares 
		distToPlayerSqr = (transform.position - player.transform.position).sqrMagnitude;
		stopDistSqr = stopDistance * stopDistance; //uses squares to take up less processing power

		// Check if this has somewere to walk:
		if ( currentWaypoint < this.waypointList.Length ) {

			if ( targetWaypoint == null ) {
				targetWaypoint = waypointList[ currentWaypoint ];
			}

			if ( distToPlayerSqr > stopDistSqr && canWaitForPlayer ) {
				willMove = false;
				TurnToFacePlayer();
			}

			// If this won't move, wait until the player is close, then move:
			if ( willMove ) {
				Move();
			} else if ( distToPlayerSqr < stopDistSqr / 10 ) {
				willMove = true;
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
		transform.rotation = Quaternion.LookRotation( lookDir, Vector3.up );
	}
}