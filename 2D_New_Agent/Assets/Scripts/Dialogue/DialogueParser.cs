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
            
            Dialogue dialogue = new Dialogue();

            List<string> contextList = new List<string>();

            contextList.Add(row[1]);

            Debug.Log(row[1]);
            if (++i < data.Length)
            {
                ;
            }

            dialogueList.Add(dialogue);  //
        }


        return dialogueList.ToArray();
    }
}

//    string[] row = data[i].Split(new char[] { ',' });  //2���� ��簡 ���. 

//    Dialogue dialogue = new Dialogue();

//    List<string> contextList = new List<string>();
//    contextList.Add(row[1]);

//    if (++i < data.Length)  //i�� ������Ű�� Data�� ���뺸�� �۴ٸ� �����ϰ� ���ش�.
//    {
//        ;
//    }
//    Debug.Log(row[1]);
//    dialogue.contexts = contextList.ToArray();
//    dialogueList.Add(dialogue);
//}
//return dialogueList.ToArray();

