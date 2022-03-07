using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractionEvent : MonoBehaviour
{
    [SerializeField] DialogueEvent dialogue;

    public Dialogue[] GetDialogues()
    {
        dialogue.dialogues = DatabaseManager.instance.GetDialogue((int)dialogue.line.x, (int)dialogue.line.y);           // 자기자신에다가
        return dialogue.dialogues;
    }

    // 대화 정보 출력하는 함수
    void DebugDialogue(Dialogue[] dialogues)
    {
        for (int i = 0; i < dialogues.Length; i++)
        {
            // 캐릭터 이름 출력
            Debug.Log(dialogues[i].name);
            // 대사들 출력
            foreach (string context in dialogues[i].contexts)
                Debug.Log(context);
        }
    }
}
