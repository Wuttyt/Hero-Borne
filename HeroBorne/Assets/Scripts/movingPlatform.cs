using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    //  The following variables allow me to change and view exactly where my platform will start  and end  according to its Z-value. it also allows me to  change and  view what speed my platform will be going at.
    public Vector3 myStartPosition = new Vector3(0, 0, 20);
    public Vector3 myEndPosition = new Vector3(2, 4, 29);
    public int speed = 3;
	public bool forward = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//I  have already declared/initializedd my variables earlier, now its time to actually put them to use and make my platform loop back and forth.

		//My platform can already move forward however it would be useless if I cant make it go backwards once it reaches its end position. Time to make it so that it goess backwards once it gets to the end bby changing the boolean direction to backwwards.
		if (gameObject.transform.position.z >= myEndPosition.z)
		{
			forward = false;
		}
		//Our boolean direction will go back to forward  once our movving platform reachess the start position again.
		if (gameObject.transform.position.z <= myStartPosition.z)
		{
			forward = true;
		}

		//If our boolean direction is forwards then we should add speed  so that our platform can actually move.
		if (forward == true)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + (Time.deltaTime * speed));
		}
		//However we must subtract the speed of our platform in order to  make it move backwards once our boolean direction IS backwards.
		if (forward == false)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - (Time.deltaTime * speed));
		}
	}
}
