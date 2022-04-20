using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 3;
<<<<<<< HEAD
    public GameObject bulletPrefab;
    public GameObject target;
    public GameObject spawnPositions;
    public float speed = 1f;
=======


>>>>>>> 2173a334a6fd2f93928af5a5206ae5870ab0a980

    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void Update()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.LookAt(target.transform);
        StartCoroutine(SendHoming(bullet));
    }    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "breakableWall")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "target")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "platform")
        {
            Destroy(gameObject);
        }
    }
}
