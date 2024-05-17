using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovementPlat : MonoBehaviour
{
	//There has  been a platform that moves forward to backward, then left to right, now its time for the up and down vertical movement along the  Y-axis!!! The following variables  will allow me to view positions and speed of the platform.
	public Vector3 myStartPosition = new Vector3(6, 15, -1);
	public Vector3 myEndPosition = new Vector3(6, 40, -1);
	public int speed = 3;
	public bool movingUp = true;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//This is where we are going to  make our platform move along the Y-axis.

		//When are platform hits the end position we are going to make it move downwards by changing our boolean direction.
		if (gameObject.transform.position.y >= myEndPosition.y)
		{
			movingUp = false;
		}
		//When the  platform reaches the start position again it is going to switch our direction boolean back to upward.
		else if (gameObject.transform.position.y <= myStartPosition.y)
		{
			movingUp = true;
		}

		//Movement Time!!
		//Here we make our platfrom move upwards along  the Y-axis.
		////This is calculated  my multiplying time since last frame, and the speed of the movement we established prior.
		if (movingUp == true)
		{
			gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		//Here we make our platform move downwards along the Y-axis.
		//This is calculated  my multiplying time since last frame, and the speed of the movement we established prior.
		else
		{
			gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
	}
 }