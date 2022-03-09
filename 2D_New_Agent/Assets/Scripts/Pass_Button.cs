using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pass_Button : MonoBehaviour
{
    // 2022.02.28 kkh - add : ���ھ� ���� �����ֱ� ���� Text ����
    public Text g_Score_text;
    // 2022.02.28 kkh - add : Pass ��ư ����
    public Button g_pass_button;

    // 2022.03.02 kkh - add : ĳ���� ���� ����ü ����
    public CustomerInfo customerInfo;

    public void Awake()
    {
        // 2022.02.28 kkh - add : GameObject �̸����� ��ü������ �������� GameObject�� GetComponent�� ������. ��, Text ��ü�� ������
        // 2022.02.28 kkh - add : �̷��� �ϴ� ������ �ٸ� ��ü�̱� ������ �ٷ� ������ �Ұ���
        g_Score_text = GameObject.Find("Score_Text").GetComponent<Text>();

        // 2022.02.28 kkh - add : ���� Pass ��ư�� ���� ��ũ��Ʈ�� �ٷ����� ����
        g_pass_button = this.transform.GetComponent<Button>();
        // 2022.02.28 kkh - add : Pass ��ư�� Ŭ�� ������ ���� Listener �߰�
        g_pass_button.onClick.AddListener(OnclickEvent);
    }

    public void Update()
    {

    }
    public void OnclickEvent()
    {
        // 2022.02.28 kkh - add : ���ھ� ����
        int nScore = int.Parse(g_Score_text.text) + 1;
        // 2022.02.28 kkh - add : �ؽ�Ʈ ����
        g_Score_text.text = nScore.ToString();
    }

    public void Pass()
    {

    }
}
