using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    //public bool canJump = false;
    public float speed = 15;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        float tempSpeed = 0;
        if (Input.GetKey(KeyCode.A))

        {
            transform.position += transform.right * Time.deltaTime * speed;
            tempSpeed -= Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += -transform.right * Time.deltaTime * speed;
            tempSpeed += Time.deltaTime * speed; 
        }
        anim.SetFloat("speed",tempSpeed);

        //if (canJump == true && Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.velocity = new Vector3(rb.velocity.x, 12, 0);
        //    canJump = false;
        //}

    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //
    //    canJump = true;
    //}
}
