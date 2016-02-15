﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	private Vector3 _walkToPos;
	private Vector3 _currentPos;

	void Update() {
		Wander ();
	}

	void Wander() {
		if (_currentPos == Vector3.zero || _currentPos == _walkToPos) {
			_walkToPos = new Vector3 (Random.Range (-36f, 36f), Random.Range (-9f, 9f), 0);
		}

		_currentPos = transform.position;

		transform.position = Vector3.MoveTowards (_currentPos, _walkToPos, 0.05f);
	}
}
