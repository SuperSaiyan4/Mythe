﻿using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {
	private int _value;
	void Awake () {
		_value = Random.Range (1, 3);
	}

	public int Value {
		get {
			return _value;
		}
	}
}