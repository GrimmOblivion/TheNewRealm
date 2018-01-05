using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int popularity = 5;
        switch (popularity)
        {
            //in the case that our pupularity is 5, say we're so popular
            case 5:
                Debug.Log("We're Awesome");
                break;
            //in the case that our popularity if 4, we're pretty cool
            case 4:
                Debug.Log("Hey we're like, pretty cool man.");
                break;
            case 3:
                Debug.Log("Hey!");
                break;
            case 2:
                Debug.Log("You still go here?");
                break;
            case 1:
                Debug.Log("Who are you again?");
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
