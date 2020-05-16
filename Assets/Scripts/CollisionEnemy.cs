using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public PlayerMovement move;
    void OnCollisionEnter(Collision col) {
        if(col.collider.tag == "Enemy"){
            move.enabled = false;
            Debug.Log("hit lol");
        }
    }
}
