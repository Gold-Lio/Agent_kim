using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;
    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>();  //�ε����� �´� int���� �ִ� Dic

    public static bool isFinish = false; //������ �Ľ� �⺻ ��


    public Dialogue[] GetDialogues()
    {
        if (instance = null)
        {
            instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.Parse(csv_FileName);  //��� �����Ͱ� ���� �迭

            //�������� �ٲ�� ����.  ���� �ȿ� �־�� �ϴ°�?
            //�ƴϸ� 

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
