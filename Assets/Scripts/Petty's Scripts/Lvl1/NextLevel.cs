using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "NextLevel0")
        {
            SceneManager.LoadScene("lvl1");
        }
        if (collision.gameObject.name == "NextLevel1")
        {
            SceneManager.LoadScene("lvl2");
        }
        if (collision.gameObject.name == "NextLevel2")
        {
            SceneManager.LoadScene("lvl3");
        }
        if (collision.gameObject.name == "NextLevel3")
        {
            SceneManager.LoadScene("lvl4");
        }
        if (collision.gameObject.name == "NextLevel4")
        {
            SceneManager.LoadScene("lvlWin");
        }
    }
}
