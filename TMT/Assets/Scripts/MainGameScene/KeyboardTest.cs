﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTest : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveObjectFunc();
    }


    private float speed_move = 3.0f;
    private float speed_rota = 10.0f;

    void moveObjectFunc()
    {
        float keyH = Input.GetAxis("Horizontal");
        float keyV = Input.GetAxis("Vertical");
        keyH = keyH * speed_move * Time.deltaTime;
        keyV = keyV * speed_move * Time.deltaTime;


        transform.Rotate(Vector3.up * speed_rota * keyH);
        transform.Rotate(Vector3.left * speed_rota * keyV);


        //transform.Translate(Vector3.right * keyH);
        //transform.Translate(Vector3.forward * keyV);
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");
        //transform.Rotate(Vector3.up * speed_rota * mouseX);
        //transform.Rotate(Vector3.left * speed_rota * mouseY);

    }
}
