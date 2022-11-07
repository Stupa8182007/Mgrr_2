using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEcontroller : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 3f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float run = 8f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    bool isGrounded;
    private Animator anim;
    

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //ôèçèêà
        if (isGrounded && velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
            velocity.y = -2f;
        }
        else
        {
            anim.SetBool("isJumping", true);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);



        if (Input.GetKey(KeyCode.Space) && isGrounded) //ïðûæîê
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


        if (Input.GetKey(KeyCode.LeftShift)) //áåã
        {
            speed = run;
            anim.SetBool("isEboshit", true);
        }
        else
        {
            speed = 3;
            anim.SetBool("isEboshit", false);
        }

        if (x == 0 && z == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
        
        if (Input.anyKey)
        {
            speed = 3;
        }
        else
        {
            speed = 0;
        }
    }
}
