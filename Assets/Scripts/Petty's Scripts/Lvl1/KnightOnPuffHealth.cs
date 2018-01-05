using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightOnPuffHealth : MonoBehaviour
{
    public int KnightHealth1 = 10;

    void Update()
    {
        if (KnightHealth1 <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            KnightHealth1 -= 5;
        }
    }
}