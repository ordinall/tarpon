using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            FindObjectOfType<FloormanagerScript>().DestroyFloor();
        }
    }
}
