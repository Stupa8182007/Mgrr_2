using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    public Transform target;
    private Vector3 _position;
    public float speedY = 4f;
    public float speedX = 4f;
    

    void Start()
    {
        _position = target.InverseTransformPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var currectPosition = target.TransformPoint(_position);
        transform.position = Vector3.Lerp(transform.position, currectPosition, speedY * Time.deltaTime);
        var currentRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, speedX * Time.deltaTime);
    }
}
