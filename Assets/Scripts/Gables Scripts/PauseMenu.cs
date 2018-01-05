using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if we press escape or p, we should pause
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) 
		{
			Time.timeScale = 0;
			//asume this script is atached to
			//pause menu canvas
			gameObject.GetComponent<Canvas>().enabled = true;
		}
	}

	public void Resume()
	{
		//reset the timescale to 1, hide the canvas
		Time.timeScale = 1;
		gameObject.GetComponent<Canvas>().enabled = false;
	}
    public void MainMenu ()
    {
        SceneManager.LoadScene("Start Scene");
    }
	public void QuitGame()
	{
		//this will quit the exe application of
		//unity when the game is built
		//it will not do anythying while runnning 
		//in the editor
		Application.Quit ();
	}

}
