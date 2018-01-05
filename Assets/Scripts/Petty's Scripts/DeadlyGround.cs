using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadlyGround : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision)
    {

        //   if (collision.gameObject.layer == 12)
        //    {
        //       SceneManager.LoadScene("lvl1");
        //    }
        if (collision.gameObject.name == "DeathGround1")
        {
            SceneManager.LoadScene("lvl1");
        }
        if (collision.gameObject.name == "DeathGround2")
        {
            SceneManager.LoadScene("lvl2");
        }
        if (collision.gameObject.name == "DeathGround3")
        {
            SceneManager.LoadScene("lvl3");
        }
        if (collision.gameObject.name == "DeathGround4")
        {
            SceneManager.LoadScene("lvl4");
        }
    }
}
