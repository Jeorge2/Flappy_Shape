using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_move : MonoBehaviour
{
    [SerializeField] float pipe_speed = -3f;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(pipe_speed, 0, 0);
        if(transform.position.x <= -32)
        {
            Destroy(gameObject);
        }
    }
}
