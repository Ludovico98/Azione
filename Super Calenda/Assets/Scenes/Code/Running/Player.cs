using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce;
    public float SideForce;


    // Update Controller for player left and right
    public void FixedUpdate()
    {
        //this makes it go forward
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        // if the player falls off the game will end 
        if (rb.position.y < -1)
        {

            FindObjectOfType<GameManager>().EndGame();
        }
    }

    // code to make it usable on phone 

    public void GoRight()
    {

        rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void GoLeft()
    {
        rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

}
