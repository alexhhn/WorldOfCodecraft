using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Camera mycam;
    public float m_speed = 0.1f;
    public Transform target;

	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        mycam.orthographicSize = (Screen.height / 100f) / 4f;

        if(target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, m_speed) + new Vector3(0, 0, -10);
        }
	}
}
