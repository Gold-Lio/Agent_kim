using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// partial 파샬로 게임매니저 클래스가 동시 다발적으로 실행됨.
/// </summary>
public partial class GameManager : MonoBehaviour  
{

    public static GameManager instance;  //게임매니저
    public GameObject gameOverPanel;

    public int gameScore;  //게임 스코어의 변수 

    public bool isGameOver
    {
        get;
        set;
    }

    public bool isGameStart
    {
        get;
        private set;
    }

    public int Score
    {
        get;
        private set;
    }

  

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
