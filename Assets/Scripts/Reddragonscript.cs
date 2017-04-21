using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reddragonscript : MonoBehaviour {
	public Sprite redDragon;
	public Sprite whiteDragon;

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<SpriteRenderer>().sprite = redDragon;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = whiteDragon;

		}
			
		
	}
}
