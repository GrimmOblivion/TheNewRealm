using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CoinPickUp : MonoBehaviour

{
    private AudioSource audioSource;
    public AudioClip CoinPickup;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
     void OnTrigerEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Coin")
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = CoinPickup;
        GetComponent<AudioSource>().Play();
        }
}
}