﻿using UnityEngine;
using System.Collections;

public class Caster : MonoBehaviour {

	// Use this for initialization
	private ICastable spell;
	public Vector3 offset;
	private Camera view;

	void Start () {
		spell = (ICastable) GetComponent(typeof(ICastable));
		view = (Camera) GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			spell.Cast(1, transform.position, offset, view.transform.rotation);
		}
	}
}
