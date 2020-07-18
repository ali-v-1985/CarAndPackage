using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera rearCamera;

    [SerializeField] private Camera driverCamera;

    [SerializeField] private float speed = 20;

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

    private float _steeringAmount;
    private float _accelerationAmount;
    private Rigidbody _playerRigidBody;

    [SerializeField] private string accelerationInput;
    public string AccelerationInput
    {
        get => accelerationInput;
        set => accelerationInput = value;
    }

    [SerializeField] private string steeringInput;
    public string SteeringInput
    {
        get => steeringInput;
        set => steeringInput = value;
    }


    // Start is called before the first frame update
    void Start()
    {
        _playerRigidBody = GetComponent<Rigidbody>();
        rearCamera.enabled = false;
        driverCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        ResetIfRequested();
        _steeringAmount = Input.GetAxis(SteeringInput);
        _accelerationAmount = Input.GetAxis(AccelerationInput);
        if (Math.Abs(transform.position.y) < 0.01)
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * Speed * _accelerationAmount));
            if (_accelerationAmount != 0)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * _steeringAmount);
            }
        }

        CheckCamera();
    }

    private static void ResetIfRequested()
    {
        if (Input.GetButtonDown("Reset"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    private void CheckCamera()
    {
        if (Input.GetButton("RearCam"))
        {
            rearCamera.enabled = true;
            driverCamera.enabled = false;
        }
        else
        {
            rearCamera.enabled = false;
            driverCamera.enabled = true;
        }
    }
}