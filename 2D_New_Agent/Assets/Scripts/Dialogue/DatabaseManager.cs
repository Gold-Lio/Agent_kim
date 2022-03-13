using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;
    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>();  //인덱스에 맞는 int값을 넣는 Dic

    public static bool isFinish = false; //데이터 파싱 기본 값


    public Dialogue[] GetDialogues()
    {
        if (instance = null)
        {
            instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.Parse(csv_FileName);  //모든 데이터가 담기는 배열

            //랜덤으로 바뀌는 값들.  포문 안에 넣어야 하는가?
            //아니면 

            System.Random random = new System.Random();


            for (int i = 0; i < dialogues.Length; i++)
            {
                dialogueDic.Add(i + 1, dialogues[i]);
            }
            isFinish = true;
            return null;
        }
    }

}
