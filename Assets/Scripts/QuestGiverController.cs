using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiverController : MonoBehaviour {

    public Text questText;
	public Transform warpTarget;
	private int i;
	public GameObject player;
	public GameObject battleCamera;

	private bool nextQuest;


	string[] messages = new string[4] {"Hello, my name is Goku. Welcome to world of codecraft, i will be your guide!",
		"To be able to take this quest, you need to bring a mate", "I see that you have a mate here already.",
		" Do you want to start the quest now?"};
	
	// Use this for initialization
	void Start () {
        questText.text = "";
		nextQuest = false;
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && nextQuest == true && i < messages.Length) {
			questText.text = messages [i];
			i++;
		} else if (Input.GetKeyDown (KeyCode.Space) && nextQuest == true && i == messages.Length) {
			player.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;
			Camera.main.enabled = false;
			battleCamera.GetComponent<Camera>().enabled = true;
		}
	}


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
			nextQuest = true;
        }
    }

	public void onTriggerExit2D(Collider2D collision) {
		if (collision.gameObject.CompareTag ("Player")) {
			nextQuest = false;
		}
	}
}
