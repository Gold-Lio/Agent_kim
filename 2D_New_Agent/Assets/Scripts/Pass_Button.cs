using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pass_Button : MonoBehaviour
{
    // 2022.02.28 kkh - add : 스코어 값을 적어주기 위한 Text 선언
    public Text g_Score_text;
    // 2022.02.28 kkh - add : Pass 버튼 선언
    public Button g_pass_button;

    // 2022.03.02 kkh - add : 캐릭터 인포 구조체 선언
    public CustomerInfo customerInfo;

    public void Awake()
    {
        // 2022.02.28 kkh - add : GameObject 이름으로 객체정보를 가져온후 GameObject의 GetComponent을 가져옴. 즉, Text 객체를 가져옴
        // 2022.02.28 kkh - add : 이렇게 하는 이유는 다른 객체이기 때문에 바로 접근이 불가능
        g_Score_text = GameObject.Find("Score_Text").GetComponent<Text>();

        // 2022.02.28 kkh - add : 현재 Pass 버튼을 위한 스크립트라서 바로접근 가능
        g_pass_button = this.transform.GetComponent<Button>();
        // 2022.02.28 kkh - add : Pass 버튼의 클릭 동작을 위한 Listener 추가
        g_pass_button.onClick.AddListener(OnclickEvent);
    }

    public void Update()
    {

    }
    public void OnclickEvent()
    {
        // 2022.02.28 kkh - add : 스코어 증가
        int nScore = int.Parse(g_Score_text.text) + 1;
        // 2022.02.28 kkh - add : 텍스트 적용
        g_Score_text.text = nScore.ToString();
    }

    public void Pass()
    {

    }
}
