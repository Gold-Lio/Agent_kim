using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;  //�̱���

    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>(); // int Ÿ������  Dialogue �����Ϳ� �����ϴ� ��ųʸ� 

    public static bool isFinish = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.Parse(csv_FileName);  // Dialogue Ŭ������ Parse �Լ��� �����ؼ� dialogues �迭 ȣ��    -��� �����Ͱ� ���� ����

            for (int i = 0; i < dialogues.Length; i++)
            {
                dialogueDic.Add(i + 1, dialogues[i]);
            }
            isFinish = true;
        }
    }

    public Dialogue[] GetDialogue(int _StartNum, int _EndNum)  // ����� ����, ���� �������� DIc�� �����Ѵ�.
    {
        List<Dialogue> dialoguesList = new List<Dialogue>();

        for (int i = 0; i <= _EndNum - _StartNum; i++)
        {
            dialoguesList.Add(dialogueDic[_StartNum + i]);
        }
        return dialoguesList.ToArray();
    }
}

