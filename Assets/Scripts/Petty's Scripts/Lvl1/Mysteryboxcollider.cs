using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mysteryboxcollider : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
 
    }
 
    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            int HitNum = Random.Range(1, 7);
            Destroy(gameObject);
            Debug.Log("MysteryBox Has been hit! The Effect is....");
            if (HitNum == 1)
            {
                Debug.Log("Speed Boost!");
            }
            if (HitNum == 2)
            {
                Debug.Log("Extra Life");
            }
            if (HitNum == 3)
            {
                Debug.Log("Invincablity! +3 HP");
            }
            if (HitNum == 4)
            {
                Debug.Log("+5 Coins!");
            }
            if (HitNum == 5)
            {
                Debug.Log("Bad Luck for you! You get nothing!");
            }
            if (HitNum == 6)
            {
                Debug.Log("Its your lucky day! You get all the effects!");
            }
        }
    }
}