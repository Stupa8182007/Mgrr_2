using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OHSHIT_ITS_ATTACKING_ME : MonoBehaviour
{
    // Start is called before the first frame update
    //Animator animator;
    void Start()
    {
        // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) ;
        else if (Input.GetButtonUp("Fire1"));
        //Debug.Log("Light_Blow");

        if (Input.GetButtonDown("Fire2")) ;
        else if (Input.GetButtonUp("Fire2"));
        //Debug.Log("Strong_Blow");
    }
}
