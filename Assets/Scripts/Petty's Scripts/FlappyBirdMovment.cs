using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlappyBirdMovment : MonoBehaviour {
    public float MoveSpeed = 3.0f;
    public float JumpSpeed = 5.0f;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = move;
        if (Input.anyKeyDown)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpSpeed));
        }
    }

        void OnCollisionEnter2D(Collision2D myCollisionInfo)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
}