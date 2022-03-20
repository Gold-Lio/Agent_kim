using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // 데이터를 직렬로 사용, 즉 인스펙터창에서 수정 가능
public class Dialogue
{
    [Tooltip("대사 내용")]
    public string contexts;
}

[System.Serializable]
public class DialogueEvent
{
    public string name;  //대화이벤트의 이름명시

    public Vector2 line; // 몇번째 줄~~대화추출하는 변수  x부터 y까지의 대화를 추출해내는 변수

    public Dialogue[] dialogues;


}