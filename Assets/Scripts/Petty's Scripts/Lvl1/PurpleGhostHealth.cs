using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleGhostHealth : MonoBehaviour
{
    public int GhostHealth1 = 10;

    void Update()
    {
        if (GhostHealth1 <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            GhostHealth1 -= 5;
        }
    }
}
