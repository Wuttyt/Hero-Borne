using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    //Distance between the Main Camera and the Player
    public Vector3 CamOffset= new Vector3(0f, 3f, -5f);

    //Holds Player capsule's  Transform inormation, like position, rotation and scale.
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        //Locates the capsule by name and gets its Transform property from the scene.
        _target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    //This is put in as a "Late" update so that the code in this script executes after the Player  moves. Allows for the most up-to-date position.
    void LateUpdate()
    {
        //This method calculates and returns a relative position in the world space.
        this.transform.position = _target.TransformPoint(CamOffset);
        
        //This updates the "Capsule's" rotation at every frame. 
        this.transform.LookAt(_target);
    }
}
