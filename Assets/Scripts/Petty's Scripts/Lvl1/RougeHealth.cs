using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RougeHealth : MonoBehaviour
{
    public int RougeHealth1 = 10;

    void Update()
    {
        if (RougeHealth1 <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            RougeHealth1 -= 5;
        }
    }
}