using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reddragonscript : MonoBehaviour {
	public Sprite redDragon;
	public Sprite frozenRedDragon;
	public Sprite deadDragon;

	public Button yourButton;

	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		this.gameObject.GetComponent<SpriteRenderer>().sprite = redDragon;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = frozenRedDragon;

		}

		if (Input.GetKeyDown (KeyCode.P)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = deadDragon;

		}
	}
		
}
