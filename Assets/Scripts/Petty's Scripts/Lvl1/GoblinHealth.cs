using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinHealth : MonoBehaviour
{
    public int GoblinHealth1 = 10;

    void Update()
    {
        if (GoblinHealth1 <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            GoblinHealth1 -= 5;
        }
    }
}