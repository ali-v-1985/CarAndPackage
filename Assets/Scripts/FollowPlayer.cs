using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FollowPlayer : MonoBehaviour
{

    private Vector3 _initialDistance;
    
    [SerializeField]
    private GameObject player;

    public GameObject Player
    {
        get => player;
        set => player = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        _initialDistance = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + _initialDistance;
    }
}
