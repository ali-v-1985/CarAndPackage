using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public float Speed
    {
        get => speed;
        set => speed = value;
    }

    [SerializeField]
    private float rotationSpeed;
    public float RotationSpeed
    {
        get => rotationSpeed;
        set => rotationSpeed = value;
    }

    private float _elevation;
    private float _rotation;
    private float _tilt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ResetIfRequested();
        // get the user's vertical input
        _elevation = Input.GetAxis("Elevation") * -1.0f;
        _rotation = Input.GetAxis("Rotation");
        _tilt = Input.GetAxis("Tilt");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * (Time.deltaTime * _elevation * rotationSpeed));
        transform.Rotate(Vector3.up * (Time.deltaTime * _rotation * rotationSpeed));
        transform.Rotate(Vector3.forward * (Time.deltaTime * _tilt * rotationSpeed));
    }
    
    private static void ResetIfRequested()
    {
        if (Input.GetButtonDown("Reset"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
