using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

	public int health = 5;
	public GameObject healthText;
	public int coins = 0;
	public GameObject coinText;

	void Update()
	{
		healthText.GetComponent<Text>().text = "Health:" + health;
		coinText.GetComponent<Text>().text = "Coins:" + coins;
		if (coins >= 10) {
			coins = 0;
			health++;
		}
	}
	void OnCollisionEnter2D(Collision2D myCollisionInfo)
	{
		if (myCollisionInfo.gameObject.tag == "Coin") 
		{
			Destroy (myCollisionInfo.gameObject);
			coins += 1;
		}
		if (myCollisionInfo.gameObject.tag == "Treasure") 
		{
			coins += 3;
			Destroy (myCollisionInfo.gameObject);
		}
		if (myCollisionInfo.gameObject.tag == "Enemy") 
		{
			health -= 1;
		}
		if (health <= 0) {
			SceneManager.LoadScene ("TryAgain");
		}
	}
}
