using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float mouseX;

    public float sensivityMouse = 200f;
    public Transform Player;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensivityMouse * Time.deltaTime;

        Player.Rotate(mouseX * new Vector3(0, 1, 0));
    }
}
