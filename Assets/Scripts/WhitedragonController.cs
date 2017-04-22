using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitedragonController : MonoBehaviour {
	public Sprite whiteDragon;
	public Sprite deadDragon;

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<SpriteRenderer>().sprite = whiteDragon;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = deadDragon;

		}		
	}
}
