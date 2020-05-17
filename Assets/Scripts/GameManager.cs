using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    bool gameEndFlag = false;

    public void GameOver()
    {
        if (!gameEndFlag)
        {
            GameOverPanel.SetActive(true);
            FindObjectOfType<Buttons>().setScore();
            gameEndFlag = true;
        }
    }

}
