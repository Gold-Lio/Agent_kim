using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueParser : MonoBehaviour
{
    public Dialogue[] Parse(string _CSVFileName)
    {
        List<Dialogue> dialogueList = new List<Dialogue>(); //��� ����Ʈ�� �����ϰ�
        TextAsset csvData = Resources.Load<TextAsset>(_CSVFileName); //Unity Resources���Ͼȿ� �ִ� csv������ ������ Ÿ���� TextAsset���� ���� 

        string[] data = csvData.text.Split(new char[] { '\n' }); // \n = enter csv���� �����ٷ� �Ѿ�� Escape��

        for (int i = 1; i < data.Length;)  //�����Ϳ� �ɰ��� �ִ� �۾�. 
        {
            string[] row = data[i].Split(new char[] { ',' });  //data i ��°�� �޸������� ���� �迭�� �ѹ� �� �ɰ���(Split) -> row������ �Ҵ�

            Dialogue dialogue = new Dialogue(); // ��� ����Ʈ ����

            dialogue.name = row[1]; //�̸��� �ִ� ����
            List<string> contextsList = new List<string>();  //contexts�� �迭Ÿ��,�� ũ�Ⱑ �������� �ʾ��� �׷��� ����Ʈ�� ���� �������ص�, toArray �� �Ѿ���� 
            contextsList.Add(row[2]);

            if(++i < data.Length)
            {
                ;
            }

            dialogue.contexts = contextsList.ToArray(); // �ٽ� �迭�� �ٲ��ش�.

            dialogueList.Add(dialogue); //dialogueList�� �ݺ��Ǹ� 1���� �߰��ɰ��̴�. 
            Debug.Log(row[1]);
            Debug.Log(row[2]);
        }
        return dialogueList.ToArray();
    }
}



