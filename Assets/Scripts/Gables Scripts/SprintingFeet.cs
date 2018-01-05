﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintingFeet : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 13)
        {
            transform.parent.GetComponent<SprintingScript>().Grounded();
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 13)
        {
            transform.parent.GetComponent<SprintingScript>().NotGrounded();
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 13)
        {
            transform.parent.GetComponent<SprintingScript>().Grounded();
        }
    }
}
