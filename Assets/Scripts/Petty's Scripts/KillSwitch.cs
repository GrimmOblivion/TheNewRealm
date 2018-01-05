using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "KillLine1")
            {
            SceneManager.LoadScene("lvl1");
        }
        if (collision.gameObject.name == "KillLine2")
        {
            SceneManager.LoadScene("lvl2");
        }
        if (collision.gameObject.name == "KillLine3")
        {
            SceneManager.LoadScene("lvl3");
        }
    }
}
