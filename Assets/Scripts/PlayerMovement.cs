using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public Rigidbody rb;

    public float forwardForce = 2000f;
    
    public float sidewaysForce = 500f;

    // FixedUpdate for Unity physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);        //on z axis add forward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //if (Input.GetKey("w"))
        //{
          //rb.AddForce(ForceMode.VelocityChange, 0, 0, forwardForce * Time.deltaTime);
        //}

        //if (Input.GetKey("s"))
        //{
            //rb.AddForce(ForceMode.VelocityChange, 0, 0, -forwardForce * Time.deltaTime);
        //}


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();


        }


    }



}
