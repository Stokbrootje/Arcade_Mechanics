using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    float n = 0F;
    float speed = 0.0003f;


    // Start is called before the first frame update
    void Start()
    {
        PointA = GameObject.Find("PointA");
        PointB = GameObject.Find("PointB");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PointB.transform.position + n * (PointA.transform.position - PointB.transform.position);

        n += speed;

        if (n > 1)
        {
            speed = -Mathf.Abs(speed);
        }

        if (n < 0)
        {
            speed = Mathf.Abs(speed);
        }
    }
}
