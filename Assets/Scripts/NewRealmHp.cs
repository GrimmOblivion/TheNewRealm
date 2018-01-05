using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewRealmHp : MonoBehaviour
{
    public GameObject Timetext;
    public float timer = 0.0f;
    public int PlayerHealth = 4;
    public GameObject PlayerHealthtext;
    public Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        Timetext.GetComponent<Text>().text = "Time: " + timer;
        timer += Time.deltaTime;
        PlayerHealthtext.GetComponent<Text>().text = "Health: " + PlayerHealth;
        if (PlayerHealth <= 0)
        {
            SceneManager.LoadScene("lvlFailed");
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "DeathGround0")
        {
            transform.position = startPos;
            PlayerHealth -= 1;   
        }
        if (collision.gameObject.name == "DeathGround1")
        {
            transform.position = startPos;
            PlayerHealth -= 1;
        }
        if (collision.gameObject.name == "DeathGround2")
        {
            transform.position = startPos;
            PlayerHealth -= 1;
        }
        if (collision.gameObject.name == "DeathGround3")
        {
            transform.position = startPos;
            PlayerHealth -= 1;
        }
        if (collision.gameObject.name == "DeathGround4")
        {
            transform.position = startPos;
            PlayerHealth -= 1;
        }
    }
}
