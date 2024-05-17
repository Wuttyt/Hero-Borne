using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    //The Range used limits the value of the "bounceheight" variable to fall between 100 to 5000.
    [Range(100, 5000)]

    //The following variable determines the height of the bounce.
    public float bounceheight;

    //This method is going to allow the Player to bounce when it collides with the object/pad that contains this script.
    private void OnCollisionEnter(Collision collision)
    {
        //This references/assigns the colliding object(in this case the Player) to the "bounceman" variable.
        GameObject bounceman = collision.gameObject;

        //This is to get the "Rigidbody" component that is attached to "Player" when it is colliding with the Bounce Pad.
        Rigidbody rb = bounceman.GetComponent<Rigidbody>();

        //This simply just adds an  upwwards force to the "Player" to make it bounce. This is determined through the value I put for the "bounceheight" variable.
        rb.AddForce(Vector3.up * bounceheight);
    }
}
