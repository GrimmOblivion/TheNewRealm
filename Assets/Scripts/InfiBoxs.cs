using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiBoxs : MonoBehaviour
{
    public float timer = 0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "InfiBox")
        {
            
        }
    }
}
