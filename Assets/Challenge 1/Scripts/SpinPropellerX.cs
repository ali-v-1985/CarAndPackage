using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField]
    private float propellerSpinSpeed = 500000.0f;
    public float PropellerRotationSpeed
    {
        get => propellerSpinSpeed;
        set => propellerSpinSpeed = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * propellerSpinSpeed);
    }
}
