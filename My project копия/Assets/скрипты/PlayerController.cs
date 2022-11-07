using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;
    public float run = 8f;
    public float tp = 3f;
    private Animator myAnimator;
    
    

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        GetInput();

    
    }

    private void GetInput()
    {
         

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
           
        }
        
       
        


        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
            
        }
       
        
       
        


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = run;
            
        }
        else
        {
            
            speed = 3;
        }

        if (Input.GetKey(KeyCode.A))
        {
            myAnimator.SetBool("isRunningA", true);
        }
        else
        {
            myAnimator.SetBool("isRunningA", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myAnimator.SetBool("isRunningS", true);
        }
        else
        {
            myAnimator.SetBool("isRunningS", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            myAnimator.SetBool("isRunningD", true);
        }
        else
        {
            myAnimator.SetBool("isRunningD", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            myAnimator.SetBool("isRunningW", true);
        }
        else
        {
            myAnimator.SetBool("isRunningW", false);
        }
    }


    
}
