using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RigidbodyJump();
        }
    }
    private void RigidbodyJump()
    {
        _rigidbody.AddForce(Vector3.up * _speed, ForceMode.VelocityChange);
    }
}
