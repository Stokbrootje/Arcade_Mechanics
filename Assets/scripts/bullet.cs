using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnPositions;
    public GameObject target;
    public float speed = 1f;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnPositions.transform.position, bulletPrefab.transform.localRotation); 
            bullet.transform.LookAt(target.transform);
            StartCoroutine(SendHoming(bullet));
        }
    }

    public IEnumerator SendHoming(GameObject bullet)
    {
        while (Vector3.Distance(bullet.transform.position, target.transform.position)>0.3f)
        {
            bullet.transform.position += (target.transform.position - bullet.transform.position).normalized * speed * Time.deltaTime;
            bullet.transform.LookAt(target.transform);
            yield return null;
        }
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
