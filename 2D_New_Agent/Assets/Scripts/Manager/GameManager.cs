using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// partial �ļ��� ���ӸŴ��� Ŭ������ ���� �ٹ������� �����.
/// </summary>
public partial class GameManager : MonoBehaviour
{
    public static GameManager instance;  //���ӸŴ���
    public GameObject gameOverPanel;
    public int gameCount; // ���� ī��Ʈ Ƚ��

    public GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���ӿ�����Ʈ 
    public Text gameCountText;  //���� ���ھ ǥ���� �ؽ�Ʈ ������Ʈ  

    public bool bisGameStart { get; set; } //���ӽ�ŸƮ ����
    public bool bisGameOver { get; set; } //���ӿ��� ���� 
    public int Score { get; private set; } // �÷��̾� ���ھ�

    void Start()
    {
        gameCount = 0;
        gameOverPanel.SetActive(false);
        bisGameOver = false;
    }

    void Update()  // ���ӿ����� �ƴѵ���
    {

    }

    public void EndGame()
    {


    }
}
