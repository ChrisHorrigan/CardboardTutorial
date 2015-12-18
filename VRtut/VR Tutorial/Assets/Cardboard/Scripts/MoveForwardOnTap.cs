using UnityEngine;
using System.Collections;

public class MoveForwardOnTap : MonoBehaviour {

	public GameObject head;
	float speed = 2f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
 		if (Input.GetKey (KeyCode.Space) || Input.GetTouch (0).phase == TouchPhase.Stationary) {

			transform.position += speed * head.transform.forward * Time.deltaTime;
		}
	}
}
