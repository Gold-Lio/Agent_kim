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
    public float minTime;
    private bool stopTime;

    private bool isClick;

    private void Update()
    {
        if (isClick)
        {
            timeBar.value -= Time.deltaTime;
            if (timeBar.value < minTime)
            {
                GameManager.instance.bisGameOver = true;
            }
        }
    }

    public void Button()
    {
        isClick = true;
    }
}