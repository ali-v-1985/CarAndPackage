using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 20;
    public float Speed
    {
        get => speed;
        set => speed = value;
    }

    [SerializeField] private float turnSpeed = 50;
    public float TurnSpeed
    {
        get => turnSpeed;
        set => turnSpeed = value;
    }

    private float _horizontalInput;
    private float _accelerationInput;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _accelerationInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (Time.deltaTime * Speed * _accelerationInput));
        if (_accelerationInput > 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * _horizontalInput);
        }
    }
}
