using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class lvl1PlayerHp : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip ArrowHit;
    public AudioClip explosion;
    public int PlayerHealth = 4;
    public GameObject PlayerHealthtext;
    public GameObject Timetext;
    public float timer = 0.0f;

    void Update()
    {
    PlayerHealthtext.GetComponent<Text>().text = "Health: " + PlayerHealth;
    Timetext.GetComponent<Text>().text = "Time: " + timer;
        timer += Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
       if (MyCollisionInfo.gameObject.tag == "Enemey")
       {
        PlayerHealth -= 1;
       }
         if (MyCollisionInfo.gameObject.tag == "EnemeyBullet")
         {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = ArrowHit;
            GetComponent<AudioSource>().Play();
            Destroy(MyCollisionInfo.gameObject);
            PlayerHealth -= 1;
         }
        if (MyCollisionInfo.gameObject.tag == "FireBall")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = explosion;
            GetComponent<AudioSource>().Play();
            Destroy(MyCollisionInfo.gameObject);
            PlayerHealth -= 3;
        }
        if (PlayerHealth <= 0 && MyCollisionInfo.gameObject.tag == "Enemey")
         {
        SceneManager.LoadScene("lvl1");
         }
    }
}