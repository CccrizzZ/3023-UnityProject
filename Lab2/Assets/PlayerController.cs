﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        transform.position = new Vector3(transform.position.x + x * Time.deltaTime, transform.position.y, transform.position.z);

        float y = Input.GetAxis("Vertical");

        transform.position = new Vector3(transform.position.x , transform.position.y + y * Time.deltaTime, transform.position.z);


    }
}
