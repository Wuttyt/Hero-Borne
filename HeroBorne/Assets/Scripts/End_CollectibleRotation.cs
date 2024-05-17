using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_CollectibleRotation : MonoBehaviour
{

    public float rotationSpeed = 1.0f; // Speed of the rotation
    public float rotationAngle = 45.0f; // Maximum angle for the oscillation

    void Start()
    {
        StartCoroutine(RotateMedal());
    }

    IEnumerator RotateMedal()
    {
        float currentAngle = 0.0f;
        bool rotatingRight = true;

        while (true) // Infinite loop
        {
            //This if and else statement will simply keep rotating the gameObject, once it reaches a certain angle, it rotates the opposite way, and does the same both left to right, right to left.
            if (rotatingRight)
            {
                //This calculates and adds onto the current angle by multiplying the speed and time passed constantly
                currentAngle += rotationSpeed * Time.deltaTime;
                if (currentAngle >= rotationAngle)
                {
                    currentAngle = rotationAngle;
                    rotatingRight = false;
                }
            }
            else
            {
                //The opposite of the formula used above, just subtractin from the currentangle instead of adding onto it
                currentAngle -= rotationSpeed * Time.deltaTime;
                if (currentAngle <= -rotationAngle)
                {
                    currentAngle = -rotationAngle;
                    rotatingRight = true;
                }
            }

            //This will rotate the game object around the Z-axis by currentAngle degrees.
            transform.rotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null; // Wait for the next frame

        }
    }
}