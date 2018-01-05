using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    // Use this for initialization
    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //get axis raw gives us the base values, ignoring how long
        //the button has been pressed, so we only get -1, or 0, or 1
        float moveX = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("x", moveX);
        //if moveX = 0,we're not getting any user imput, so we
        //are not walking, tell that to the animator
        if(moveX == 0)
        {
            anim.SetBool("isWalking", false);
        }else
        {
            anim.SetBool("isWalking", true);
        }


	}
}
