using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public float maxLives = 3;
    private int lives;
    private Image[] images;
    private Image[] hearts;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image[] images = GetComponentsInChildren<Image>();
        int count = 0;
        foreach (Image img in images)
        {
            if (img.name == "Heart")
            {
                count++;
            }
        }

        hearts = new Image[count];
        count = 0;
        foreach (Image img in images)
        {
            if (img.name == "Heart")
            {
                hearts[count] = img;
                count++;
            }
        }
        
        lives = hearts.Length;
        maxLives = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int Lives
    {
        get { return lives; }
        set
        {
            if (value <= maxLives && value >= 0)
            {
                lives = value;
                for (int i = 0; i < hearts.Length; i++)
                {
                    if (i < lives)
                    {
                        hearts[i].enabled = true;
                    }
                    else
                    {
                        hearts[i].enabled = false;
                    }
                }
                if (lives == 0) pauseGame();
            }

        }
    }

    private void pauseGame()
    {

    }


}

