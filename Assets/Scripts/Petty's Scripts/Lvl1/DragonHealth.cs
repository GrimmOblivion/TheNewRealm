using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DragonHealth : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip DragonHurt;

    public int DragonHealth1 = 10;

    void Update()
    {
        if (DragonHealth1 <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            DragonHealth1 -= 5;
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = DragonHurt;
            GetComponent<AudioSource>().Play();
        }
    }
}