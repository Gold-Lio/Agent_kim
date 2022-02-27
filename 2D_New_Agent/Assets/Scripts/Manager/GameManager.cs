using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public partial class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameObject gameOverPanel;


    public bool isGameOver
    {
        get;
        private set;
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
