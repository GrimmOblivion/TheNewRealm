using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniControlls : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        //assuesm is attched to the player, or an object with an animator
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y) > 0);
        if (isWalking) {
            anim.SetFloat("X", input_x);
            anim.SetFloat("Y", input_y);

        }
       // anim.SetBool("isWalking", isWalking);
    }
}
