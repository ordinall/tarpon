using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloormanagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    GameObject Floor;
    public GameObject newFloor;
    public void makeNewFloor(){
        newFloor = Instantiate(obj, Floor.transform.position + new Vector3(0,0,1000), Floor.transform.rotation);
    }

    public void DestroyFloor(){
        Destroy(Floor);
        Floor = newFloor;
    }
}
