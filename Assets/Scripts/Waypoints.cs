using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

	public Transform[] waypointList;
	public int currentWaypoint = 0;
	public float moveSpeed = 4f;

	Transform targetWaypoint;


	void Update() {
		// Check if object has somewere to walk:
		if ( currentWaypoint < this.waypointList.Length ) {
			if ( targetWaypoint == null ) {
				targetWaypoint = waypointList[ currentWaypoint ];
			}

			Move();
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
}