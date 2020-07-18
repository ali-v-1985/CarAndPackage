using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveDirectlyAICar : MonoBehaviour
{
    [SerializeField]
    private float speed = 20;
    public float Speed
    {
        get => speed;
        set => speed = value;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(transform.position.y) < 0.01)
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * Speed));
        }

    }
}
