﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairRotate : MonoBehaviour
{
    public float YRotate ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, YRotate, 0f) * Time.deltaTime);
    }
}