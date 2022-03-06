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
    public int gameCount; // 성공 카운트 횟수

    public GameObject gameoverText; // 게임오버 시 활성화할 텍스트 게임오브젝트 
    public Text gameCountText;  //게임 스코어를 표시할 텍스트 컴포넌트  

    public bool bisGameStart { get; set; } //게임스타트 상태
    public bool bisGameOver { get; set; } //게임오버 상태 
    public int Score { get; private set; } // 플레이어 스코어

    void Start()
    {
        gameCount = 0;
        gameOverPanel.SetActive(false);
        bisGameOver = false;
    }

    void Update()  // 게임오버가 아닌동안
    {

    }

    public void EndGame()
    {


    }
}
