using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Time_bar : MonoBehaviour
{
    [SerializeField]
    public Slider timeBar;
    public float gameTime;

    private bool stopTime;

    void Start()
    {
        stopTime = false;
        timeBar.maxValue = gameTime;
        timeBar.value = gameTime;
        
    }

    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60);

        string textTime = string.Format($"{0:0}:{1:00}", minutes, seconds);

        if(time <= 0)
        {
            stopTime = true;
            GameManager.instance.isGameOver = true;
        }
        if(stopTime == false)
        {
                      timeBar.value = time;
        }
    }
}

