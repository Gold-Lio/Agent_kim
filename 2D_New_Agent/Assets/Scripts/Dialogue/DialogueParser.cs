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
        
        for(int i = 1; i < data.Length;)  //�����Ϳ� �ɰ��� �ִ� �۾�. 
        {
            string[] row = data[i].Split(new char[] { ',' });  //data i ��°�� �޸������� ���� �迭�� �ѹ� �� �ɰ���(Split) -> row������ �Ҵ�

            Dialogue dialogue = new Dialogue(); // ��� ����Ʈ ����

            ///�̸� ���� ��� ���� �ߴ� �ڵ�
            dialogue.name = row[1];
            List<string> contextList = new List<string>();
            contextList.Add(row[2]);

            //do
            //{
            //    contextList.Add(row[1]);
            //    Debug.Log(row[1]);
            //    if (++i < data.Length)
            //    {
            //        row = data[i].Split(new char[] { ',' });
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            while (row[0].ToString() == ""); // �̰� �����̸� ��縦 �߰� 

            dialogue.contexts = contextList.ToArray();
            dialogueList.Add(dialogue);
        
        }

        return dialogueList.ToArray();  //Dialoge ����Ʈ�� �迭�� ��ȯ
    }

    private void Start()
    {
        Parse("��Ȳ����");
    }

}


