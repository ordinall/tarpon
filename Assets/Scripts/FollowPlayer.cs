using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransf;
    public Vector3 cameraOffset;
    void Update()
    {
        transform.position = playerTransf.position + cameraOffset;
    }
}
