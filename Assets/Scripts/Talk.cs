using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour {

    public Text questText;

	// Use this for initialization
	void Start () {
        questText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            questText.text = "Hello, my name is Goku. Welcome to world of codecraft, i will be your guide!";
            questText.gameObject.SetActive(true);
        }
    }

}
