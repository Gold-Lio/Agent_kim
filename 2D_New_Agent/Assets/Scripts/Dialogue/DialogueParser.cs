using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueParser : MonoBehaviour
{
    public Dialogue[] Parse(string _CSVFileName)
    {
        List<Dialogue> dialogueList = new List<Dialogue>(); //대사 리스트를 생성하고
        TextAsset csvData = Resources.Load<TextAsset>(_CSVFileName); //Unity Resources파일안에 있는 csv파일을 가져와 타입을 TextAsset으로 변경 

        string[] data = csvData.text.Split(new char[] { '\n' }); // \n = enter csv에서 다음줄로 넘어가는 Escape문

        for (int i = 1; i < data.Length;)  //데이터에 쪼개서 넣는 작업. 
        {
            string[] row = data[i].Split(new char[] { ',' });  //data i 번째를 콤마단위를 가진 배열로 한번 더 쪼개서(Split) -> row변수에 할당

            Dialogue dialogue = new Dialogue(); // 대사 리스트 생성

            dialogue.name = row[1]; //이름을 넣는 공간
            List<string> contextsList = new List<string>();  //contexts는 배열타입,즉 크기가 정해지지 않았음 그래서 리스트로 먼저 지정해준뒤, toArray 로 넘어갈꺼야 
            contextsList.Add(row[2]);

            if(++i < data.Length)
            {
                ;
            }

            dialogue.contexts = contextsList.ToArray(); // 다시 배열로 바꿔준다.

            dialogueList.Add(dialogue); //dialogueList에 반복되며 1개씩 추가될것이다. 
            Debug.Log(row[1]);
            Debug.Log(row[2]);
        }
        return dialogueList.ToArray();
    }
}



