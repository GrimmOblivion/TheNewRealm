using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class CoinShooting : MonoBehaviour {

    private AudioSource audioSource;
    public  AudioClip CoinPickup;
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject Fire3;
    public float bulletSpeed = 10f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 0.1f;
    private float timer = 0f;
    public int coins = 0;
    public GameObject coinText;
    public GameObject InfiBoxs;
    public float InfiBoxTimer = 0;
    public bool InfiBox = true;
    public GameObject InfiBoxText;
    public GameObject Canvass;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        timer = shootDelay;
    }
    void OnTriggerEnter2D(Collider2D MyCollisionInfo)
    {
        Debug.Log(MyCollisionInfo.gameObject.name);
        if (MyCollisionInfo.gameObject.tag == "Coin")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = CoinPickup;
            GetComponent<AudioSource>().Play();
            Destroy(MyCollisionInfo.gameObject);
            coins += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        coinText.GetComponent<Text>().text = "Coins: " + coins;

        timer += Time.deltaTime;
        InfiBoxTimer += Time.deltaTime;
        //   if (InfiBoxTimer >= 11) {
        //     InfiBoxTimer -= 10;
        //   }

        if (Input.GetButtonDown("Fire1") && timer >= shootDelay && coins >= 1 && !InfiBox)
        {
            bulletLifetime = 60;

            //get the mouse position
            var mousePosition = Input.mousePosition;
            //convert the mouse position from pixels to x,y values in the game
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //create the shoot direction, which is calculated by mousePosition - playerPosition
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            //create the bullet object

            //reduce the length of the direction to 1, so it is always the same regardless of how far away
            //the mouse is from the player. 
            shootDirection.Normalize();

            Vector3 spawnPosition = transform.position;
            spawnPosition.x += shootDirection.x * 0.6f;
            spawnPosition.y += shootDirection.y * 0.6f;

            //create the object in front of the player
            GameObject bullet = (GameObject)Instantiate(prefab, spawnPosition, Quaternion.identity);
            //apply the velocity in the shoot direction
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            timer = 0;

            coins--;
        }
        if (Input.GetButton("Fire3") && coins >=1)
        {
            bulletLifetime = 2;
            coins--;
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            Vector3 spawnPosition = transform.position;
            spawnPosition.x += shootDirection.x * 0.2f;
            spawnPosition.y += shootDirection.y * 0.2f;
            GameObject bullet = (GameObject)Instantiate(Fire3, spawnPosition, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
            Destroy(bullet, bulletLifetime);
        }
        if (Input.GetButtonDown("Fire1") && InfiBox)
        {
            bulletLifetime = 30;

            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

            shootDirection.Normalize();

            Vector3 spawnPosition = transform.position;
            spawnPosition.x += shootDirection.x * 0.6f;
            spawnPosition.y += shootDirection.y * 0.6f;

            GameObject InfiBoxs = (GameObject)Instantiate(prefab2, spawnPosition, Quaternion.identity);
            InfiBoxs.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
            Destroy(InfiBoxs, bulletLifetime);


        }
        if (InfiBoxTimer >= 10)
        {
            InfiBox = false;
        }
        if (InfiBox == true)
        {
            InfiBoxText.GetComponent<Text>().text = "Infinite Box Timer: " + InfiBoxTimer;
            Canvass.GetComponent<Canvas>().enabled = true;
        } else if(InfiBox == false)
        {
            Canvass.GetComponent<Canvas>().enabled = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "InfiBox")
        {
            InfiBoxTimer = 0;

            InfiBox = true;
        }
    }
}
