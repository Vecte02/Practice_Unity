using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyMove : MonoBehaviour
{
    int Speed = 4;
    Rigidbody2D rigi;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isMove = Move();
        anim.SetBool("Move", isMove);

        if (Input.GetKey(KeyCode.Space)) anim.SetTrigger("Launch");
    }

    bool Move()
    {
        Vector3 move = Vector3.zero;

        int X = (int)Input.GetAxisRaw("Horizontal");
        int Y = (int)Input.GetAxisRaw("Vertical");

        if (X != 0)
        {
            move += new Vector3(X,0,0);
            anim.SetFloat("Look X", X);
            anim.SetFloat("Look Y", 0);
        }

        if (Y != 0)
        {
            move += new Vector3(0, Y, 0);
            anim.SetFloat("Look Y", Y);
            anim.SetFloat("Look X", 0);
        }

        transform.position += move * Speed * Time.deltaTime;
        //움직이고 있는지 확인
        return move != Vector3.zero;
    }
}
