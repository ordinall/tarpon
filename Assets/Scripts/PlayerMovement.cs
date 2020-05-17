using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public int forwardSpeed = 100;
    public int sidewaysSpeed = 10;
    public Text text;
    int safeTrig = 1;
    public Rigidbody player;
    int destroyed = 0;
    bool inCollision;
    void Start()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    }
    void FixedUpdate()
    {
        player.AddForce(Input.GetAxisRaw("Horizontal") * sidewaysSpeed * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        player.AddForce(0, 0, forwardSpeed * Time.fixedDeltaTime);
    }

    void Update()
    {
        inCollision = false;
        text.text = ((int)Mathf.RoundToInt((GetComponent<Transform>().localPosition.z - 4) * 0.3f * ((GetComponent<Transform>().localPosition.z - 4) * 0.3f * 0.001f))).ToString();
        if (player.transform.position.y < -2)
        {
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floorDest" && destroyed == 0)
        {
            FindObjectOfType<FloormanagerScript>().DestroyFloor();
            destroyed = 1;
        }
        if (other.tag == "floorSpawn" && destroyed == 1)
        {
            FindObjectOfType<FloormanagerScript>().makeNewFloor();
            destroyed = 0;
        }
        if (inCollision)
        {
            return;
        }
        if (other.tag == "patterntrigg" && safeTrig == 1)
        {
            FindObjectOfType<PatternManagerScript>().PatternTrigger();
            safeTrig = 0;
            StartCoroutine(Reset());
        }
    }

    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "Enemy")
        {
            Invoke("EndGame", 0.3f);
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }

    void EndGame()
    {
        FindObjectOfType<GameManager>().GameOver();
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(1);
        safeTrig = 1;
    }
}
