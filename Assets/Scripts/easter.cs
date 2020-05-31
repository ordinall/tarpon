using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class easter : MonoBehaviour
{
    int clicks = 1;
    string vertype = "Alpha";
    public Image fishimg;
    public AudioSource music;
    public AudioSource menuMusic;
    public Text text;
    string[] easterss ={
        "Well, hello there",
        "How are you?",
        "Okay, this is a little disturbing",
        "Stop, What are you doing?",
        "Hey man, stop",
        "What is making you click on this mere collection of pixels",
        "Yep, thats right, Curiosity",
        "It is in human nature",
        "Well, you can go away, there is nothing to be seen here",
        "you are really curious",
        "“The mind is not a vessel to be filled, but a fire to be kindled.” - Putarch, A greek philosopher",
        "btw leave that",
        "Enjoy this",
        "Caramella Girls - Caramelldansen (swedish), if you want the source",
        ";) bye"
    };
    public void easter_click()
    {
        clicks++;
        if (clicks <= 9)
        {
            if (clicks == 4)
            {
                vertype = "Beta";
            }
            if (clicks == 8)
            {
                vertype = "Stable";
            }
            text.text = "Version 0.0." + clicks + " " + vertype;
        }
        else if (clicks < 25)
        {
            text.text = easterss[clicks-10];
            if (clicks == 22)
            {
                menuMusic.Stop();
                music.Play();
            }
            if (clicks == 24)
            {
                fishimg.color = new Color32(255, 255, 255, 202);
            }
        }
        else
        {
            text.text = "";
        }
    }
}
