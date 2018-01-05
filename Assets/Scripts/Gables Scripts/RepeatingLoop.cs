using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingLoop : MonoBehaviour {

	void Start () {

        if(true)
        {
            Debug.Log("Do The Thing!");
        }

       for (int clothes = 1; clothes < 11; clothes++)
        {
            Debug.Log("Washing " + clothes + " items");
        }

        for (int counting = 176; counting < 1001; counting++)
        {
            Debug.Log("There are currently " + counting +" numbers between 176 and 1000");
        }

        for (int roll = 1; roll < 101; roll++)
        {
            int dieRoll1 = Random.Range(1, 7);
            int dieRoll2 = Random.Range(1, 7);
            int sumP1 = dieRoll1 + dieRoll2;
            if (sumP1 < 12)
            {
                Debug.Log("Close But No Cigar!");
            }
            if (sumP1 == 12)
            {
                Debug.Log("You Win!!");
                break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
