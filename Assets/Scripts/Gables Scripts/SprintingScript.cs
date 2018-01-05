using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintingScript : MonoBehaviour {

    // Use this for initialization
    public float moveSpeed = 1.0f;
    private float startSpeed;
    public float sprintSpeed = 1.0f;
    private float startjumpSpeed;
    public float jumpSpeed = 1.0f;
    public float sprintjumpSpeed = 1.0f;
    private bool grounded = false;
    Animator anim;
    void Start () {
        startSpeed = moveSpeed;
        startjumpSpeed = jumpSpeed;
        anim = GetComponent<Animator>();
       
	}
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            //we are jumping now
            anim.SetBool("isJumping", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }
        if (Input.GetKey(KeyCode.LeftShift) && grounded)
        {
            moveSpeed = sprintSpeed;
            jumpSpeed = sprintjumpSpeed;
            Camera.main.GetComponent<Camera>().orthographicSize = 6;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = startSpeed;
            jumpSpeed = startjumpSpeed;
            Camera.main.GetComponent<Camera>().orthographicSize = 5;
        }
        
    }

    public void Grounded()
    {
        grounded = true;
        anim.SetBool("isJumping", false);
    }

    public void NotGrounded()
    {
        grounded = false;
    }

}
