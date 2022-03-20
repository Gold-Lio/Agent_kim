using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;
    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>();  //인덱스에 맞는 int값을 넣는 Dic

    public static bool isFinish = false; //데이터 파싱 기본 값

    private void Awake()
    {
        if (instance = null)
        {
            instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.Parse(csv_FileName); // 모든 데이터가 담기는 배열. 

            for (int i = 0; i < dialogues.Length; i++)
            {
                dialogueDic.Add(i + 1, dialogues[i]);
            }
            isFinish = true;
        }
    }

    public Dialogue[] GetDialogue(int StartNum)
    { // 더해지는 값. 
        List<Dialogue> dialogueList = new List<Dialogue>();
        for (int i = 0; i < StartNum; i++)
        {
           dialogueList.Add(dialogueDic[++i]); 
        }
        return dialogueList.ToArray();
    }
}

