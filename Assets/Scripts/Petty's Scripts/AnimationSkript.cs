using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSkript : MonoBehaviour {

    // Use this for initialization
    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //GetAxisRaw gives us base values, ignoresing how long the button was pressed
        float moveX = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("X", moveX);
        if (moveX == 0)
        {
            //if moveX = 0, were not getting any user imput then we are not walking, tells animator
            anim.SetBool("isWalking", false);
        }
        else {
            anim.SetBool("isWalking", true);
        }

	}
}
