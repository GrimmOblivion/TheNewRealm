using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
	public int health = 5;
	public GameObject prefab;

	void OnCollisionEnter2D(Collision2D myCollisionInfo)
	{
		
		if (myCollisionInfo.gameObject.tag == "Bullet") 
		{
			Destroy (myCollisionInfo.gameObject);
			health -= 1;
		}

	}
	void Update () {
		if (health <= 0) {
            if (prefab != null)
            {
                GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            }
			Destroy (gameObject);
		}
	}
}
