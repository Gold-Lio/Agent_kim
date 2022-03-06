using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;  //싱글턴

    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>(); // int 타입으로  Dialogue 데이터에 접근하는 딕셔너리 

    public static bool isFinish = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.Parse(csv_FileName);  // Dialogue 클래스에 Parse 함수에 접근해서 dialogues 배열 호출    -모든 데이터가 담기는 변수

            for (int i = 0; i < dialogues.Length; i++)
            {
                dialogueDic.Add(i + 1, dialogues[i]);
            }
            isFinish = true;
        }
    }

    public Dialogue[] GetDialogue(int _StartNum, int _EndNum)  // 대사의 시작, 끝을 기준으로 DIc을 참조한다.
    {
        List<Dialogue> dialoguesList = new List<Dialogue>();

        for (int i = 0; i <= _EndNum - _StartNum; i++)
        {
            dialoguesList.Add(dialogueDic[_StartNum + i]);
        }
        return dialoguesList.ToArray();
    }
}

