using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    private Vector3 _initialDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        _initialDistance = plane.transform.position + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + _initialDistance;
    }
}
