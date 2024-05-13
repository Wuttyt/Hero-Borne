using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left2RightMove : MonoBehaviour
{
	// I'm going to need some variables that tell me about position
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
		//I'm going to need to do some math on those variables 
		//over and over
		//the goal here is to make the object move

		//gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,gameObject.transform.position.z + 1);

		//If we reach the end then change our direction boolean to go backward
		if (gameObject.transform.position.x >= myEndPosition.x)
		{
			moveRight = false;
		}
		//If we reach the begining then change our direction boolean to go forward
		else if (gameObject.transform.position.x <= myStartPosition.x)
		{
			moveRight = true;
		}

		//If we are going forward then add the speed
		if (moveRight == true)
		{
			gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
		}
		//If we are going backward then subtract the speed
		else
		{
			gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
		}
	}
}