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
            if (rotatingRight)
            {
                currentAngle += rotationSpeed * Time.deltaTime;
                if (currentAngle >= rotationAngle)
                {
                    currentAngle = rotationAngle;
                    rotatingRight = false;
                }
            }
            else
            {
                currentAngle -= rotationSpeed * Time.deltaTime;
                if (currentAngle <= -rotationAngle)
                {
                    currentAngle = -rotationAngle;
                    rotatingRight = true;
                }
            }

            transform.rotation = Quaternion.Euler(0, 0, currentAngle);
            yield return null; // Wait for the next frame
        }
    }
}