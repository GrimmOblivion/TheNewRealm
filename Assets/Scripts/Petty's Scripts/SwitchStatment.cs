using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatment : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int populatity = 5;
        switch (populatity) {
            //we will switch the out come based on popularity
            case 5:
                Debug.Log("We are so popular!");
                break;
            case 4:
                Debug.Log("We're like, Pretty cool man.");
                break;
            case 3:
                Debug.Log("I mean i got Friends");
                break;
            case 2:
                Debug.Log("I only have one friend...and its my Mom...");
                break;
            case 1:
                Debug.Log("Why does no one like MEEEEEEEEE! * breaks down in tears*");
                break;
            default:
                Debug.Log("Your popularity is out of bounds");
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
