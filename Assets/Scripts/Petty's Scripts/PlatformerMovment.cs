using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlatformerMovment : MonoBehaviour {
  /*  public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    private bool grounded = false;
    public float sprintSpeed = 2.0f;
    Vector2 move;
    void Start() {
        move = Vector2.zero;

    }


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveX;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //if we collid with anything on the ground layer we are grounded
            //layer 8 is our ground layer
            if (collision.gameObject.layer == 8) {
                grounded = true;
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {

            if (collision.gameObject.layer == 8)
            {
                grounded = false;
            }
        }
        private void OnCollisionStay2D(Collision2D collision)
        {

            if (collision.gameObject.layer == 8)
            {
                grounded = true;
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {

            gameObject.GetComponent<Rigidbody2D>().velocity = move * sprintSpeed;

        }
        else
        {

            gameObject.GetComponent<Rigidbody2D>().velocity = move * moveSpeed;
        }
    }*/
}
