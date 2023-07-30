using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyMove : MonoBehaviour
{
    int Speed = 4;
    Rigidbody2D rigi;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0) move = Vector3.left;
        else if (Input.GetAxisRaw("Horizontal") > 0) move = Vector3.right;

        if(Input.GetAxisRaw("Vertical") < 0) move += Vector3.down;
        else if (Input.GetAxisRaw("Vertical") > 0) move += Vector3.up;

        transform.position += move * Speed * Time.deltaTime;
    }
}
