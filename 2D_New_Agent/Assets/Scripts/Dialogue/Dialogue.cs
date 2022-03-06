using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // 데이터를 직렬로 사용, 즉 인스펙터창에서 수정 가능
public class Dialogue
{
    [Tooltip("대사 치는 캐릭터의 이름")]
    public string name;

    [Tooltip("대사 내용")]
    [TextArea(2,10)]
    public string[] sentences;
    internal string[] contexts;
}

[System.Serializable]
public class DialogueEvent
{
    public string name; //이벤트 이름 명시

    public Vector2 line; // 몇번째 줄~~대화추출하는 변수
    
    [SerializeField]
    public Dialogue[] dialogues;
}