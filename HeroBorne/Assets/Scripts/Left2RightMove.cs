using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left2RightMove : MonoBehaviour
{
	//I already have a moving platform that moves forward and backwards according to its Z-value. Now its  time to change it  up so that it moves left and right according to its X-value. These are my  variables  that talk about my platforms positions and  its speed.
	public Vector3 myStartPosition = new Vector3(2, 38, 36);
	public Vector3 myEndPosition = new Vector3(2, 38, 36);
	public int speed = 3;
	public bool moveRight = true;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Again this will be the part where I work some magic to make my platform move from left to right andd vice versa so that it functions properly.

		//Once the platform reaches the end position then change the boolean direction to go left.
		if (gameObject.transform.position.x >= myEndPosition.x)
		{
			moveRight = false;
		}
		//Once the platform  reaches back  to the start position our boolean direaction wwill be changed to go right again.
		else if (gameObject.transform.position.x <= myStartPosition.x)
		{
			moveRight = true;
		}

		//This is the part where the platform  moves based on current direction.
		//This first "if" code moves the  platform to the right accordding to its X-value.
		if (moveRight == true)
		{
			gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
		}
		//This one however, you guessed it, moves it to the left according to its X-value.
		else
		{
			gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
		}
	}
}