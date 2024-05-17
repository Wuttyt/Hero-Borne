using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    //If my player collides with an item using this script, the item gets "destoyed" to mimic the player picking up the item. This  is followed by a text prompt that notifies the player about picking up said item.
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);

            Debug.Log("Item collected!");
        }
    }
}
