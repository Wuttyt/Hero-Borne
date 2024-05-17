using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour
{
    //Simply just making the variable for later use.
    int buildindex;

    // Start is called before the first frame update
    void Start()
    {
        //This finds the build index for the current scene and store it into the build index.
        buildindex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider myCollision)
    {
        //This loads a new scene by referencing which scene the Player is on currently through the build index and then simply adding one which will load the next scene in the list in the build index. Each scene has a numeric value in the build index.  
        SceneManager.LoadScene(buildindex + 1);
    }
}
