using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour {

	/* Waypoint Movement Variables */
	public Transform[] waypointList;
	public int currentWaypoint = 0;
	public float moveSpeed = 3.6f;

	Transform targetWaypoint;

	public AudioSource footsteps;


	/* Player-Tracking Variables */
	public GameObject player;
	public float stopDistance; //the distance at which dad will stop to wait for the player
	public bool canWaitForPlayer;
	public static bool isWaiting = false;

	float distToPlayerSqr;
	float stopDistSqr;


	void Start() {
		footsteps.Play();
		footsteps.Pause();
	}

	void FixedUpdate() {
		// Prevents rotation around X or Z axes:
		transform.position.Set( transform.position.x, 0f, transform.position.z );

		// Calculates distance to player, squared:
		distToPlayerSqr = (transform.position - player.transform.position).sqrMagnitude;
		stopDistSqr = stopDistance * stopDistance; //uses squares to take up less processing power

		// Check if this has somewere to walk:
		if ( currentWaypoint < this.waypointList.Length ) {

			if ( targetWaypoint == null ) {
				targetWaypoint = waypointList[ currentWaypoint ];
			}

			// Stops if too far from the player:
			if ( distToPlayerSqr > stopDistSqr && canWaitForPlayer ) {
				isWaiting = true;
				footsteps.Pause();
				TurnToFacePlayer();
			}

			// If this won't move, wait until the player is close, then move:
			if ( !isWaiting ) {
				Move();
				footsteps.UnPause();
			} else if ( distToPlayerSqr < stopDistSqr / 10 ) {
				isWaiting = false;
			}
			
		}
	}

	void Move() {
		Vector3 waypointDir = targetWaypoint.position - transform.position;
		//waypointDir.y = 0f;

		// Rotate towards target waypoint:
		transform.forward = Vector3.RotateTowards( transform.forward, waypointDir, moveSpeed * Time.deltaTime, 0.0f );

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