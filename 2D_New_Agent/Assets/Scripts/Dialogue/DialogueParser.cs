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
        
        for(int i = 1; i < data.Length;)  //데이터에 쪼개서 넣는 작업. 
        {
            string[] row = data[i].Split(new char[] { ',' });  //data i 번째를 콤마단위를 가진 배열로 한번 더 쪼개서(Split) -> row변수에 할당

            Dialogue dialogue = new Dialogue(); // 대사 리스트 생성

            ///이름 한줄 대사 한줄 뜨는 코드
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
            while (row[0].ToString() == ""); // 이게 여백이면 대사를 추가 

            dialogue.contexts = contextList.ToArray();
            dialogueList.Add(dialogue);
        
        }

        return dialogueList.ToArray();  //Dialoge 리스트를 배열로 변환
    }

    private void Start()
    {
        Parse("주황버섯");
    }

}


