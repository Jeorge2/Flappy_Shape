using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfly : MonoBehaviour
{
    public Rigidbody2D rb;
    float pipeSpeed = 10f;
    public float jump = 20f;
    Vector3 velocity;
    public GameObject rotateobject;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.up;
        if (Input.GetKeyDown("space")||Input.GetKeyDown("mouse 0"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jump);
        }
        if (rb.velocity.y > 0)
        {
            rotateobject.transform.rotation = Quaternion.Euler(0, 0, -22.5f);
        }
        else
        {
            rotateobject.transform.rotation = Quaternion.Euler(0,0, 22.5f);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }

}
