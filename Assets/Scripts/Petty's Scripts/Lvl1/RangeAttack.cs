using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour {

    public float timer = 0f;
    public GameObject Bullet;
    public float shootDistance = 10.0f;
    public bool BulletSpawned = true;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Vector3 spawnPosition = transform.position;
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 shootDir = playerPos - spawnPosition;
        if (!BulletSpawned)
        {
            BulletSpawned = false;
        }
        if (timer >= 2 && shootDir.magnitude < shootDistance && BulletSpawned)
        {
            BulletSpawned = true;
            GameObject Bullet = (GameObject)Instantiate(this.Bullet, spawnPosition, Quaternion.identity);
           // Bullet.GetComponent<EnemyMove> ().player = GameObject.FindGameObjectWithTag ("Player");

            timer = 0;
        }
    }
}
