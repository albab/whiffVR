using UnityEngine;
using System.Collections;

public class SwitchRooms : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("t")) {
			print("Test Environment");
			Application.LoadLevel("Testing Environment");
		}
		if (Input.GetKey ("f")) {
			print("Flower Room");
			Application.LoadLevel("Flower Room");
		}
		if (Input.GetKey ("c")) {
			print("Coffee Room");
			Application.LoadLevel("Coffee Room");
		}
	}
}
