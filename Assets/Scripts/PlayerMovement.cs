using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public int forwardSpeed = 100;
    public int sidewaysSpeed = 10;
    public Text text;
    public Rigidbody player;

    void FixedUpdate()
    {
        player.AddForce(Input.GetAxisRaw("Horizontal") * sidewaysSpeed * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        player.AddForce(0, 0, forwardSpeed * Time.fixedDeltaTime);
    }

    void Update()
    {
        text.text = ((int)Mathf.RoundToInt((GetComponent<Transform>().localPosition.z - 4) * 0.3f * ((GetComponent<Transform>().localPosition.z - 4) * 0.3f * 0.001f)) ).ToString();
    }
}
