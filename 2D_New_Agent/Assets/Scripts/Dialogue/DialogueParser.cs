using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ǻ� ��ȭ 1���� ������, �ϴ��� �迭�� ������ ���Ҵ�.. 
/// ���߿� string ������ ���ľ��Ѵ�. 
/// </summary>
public class DialogueParser : MonoBehaviour
{
    public Dialogue[] Parse(string _CSVFileName)
    {
        List<Dialogue> dialogueList = new List<Dialogue>(); //��� ����Ʈ�� �����ϰ�
        TextAsset csvData = Resources.Load<TextAsset>(_CSVFileName); //Unity Resources ���� ���Ͼȿ� �ִ� csv������ ������ Ÿ���� TextAsset���� ���� 

        string[] data = csvData.text.Split(new char[] { '\n' }); // \n = enter csv���� �����ٷ� �Ѿ�� Escape��

        for (int i = 1; i < data.Length;)  //�����Ϳ� �ɰ��� �ִ� �۾�. 
        {
            string[] row = data[i].Split(new char[] { ',' });
            
            Dialogue dialogue = new Dialogue(); // ��� ����Ʈ ����

            List<string> contextList = new List<string>();   //����Ʈ�� ����� �׸��� �ٽ� �迭�� �����ϴ� ���� �ʿ�. 

            contextList.Add(row[1]);

            Debug.Log(row[1]);
            if (++i < data.Length) //i�� �̸� ������Ű�� data.length ���� �۴ٸ� ; 
            {
                ;
            }

            dialogue.contexts = contextList.ToArray();
            dialogueList.Add(dialogue);
           
        }

        return dialogueList.ToArray();
    }

}

