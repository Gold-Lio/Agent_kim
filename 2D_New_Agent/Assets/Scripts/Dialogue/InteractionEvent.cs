using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractionEvent : MonoBehaviour
{
    [SerializeField] DialogueEvent dialogue;

    public Dialogue[] GetDialogues()
    {
        dialogue.dialogues = DatabaseManager.instance.GetDialogue((int)dialogue.line.x, (int)dialogue.line.y);           // �ڱ��ڽſ��ٰ�
        return dialogue.dialogues;
    }

    // ��ȭ ���� ����ϴ� �Լ�
    void DebugDialogue(Dialogue[] dialogues)
    {
        for (int i = 0; i < dialogues.Length; i++)
        {
            // ĳ���� �̸� ���
            Debug.Log(dialogues[i].name);
            // ���� ���
            foreach (string context in dialogues[i].contexts)
                Debug.Log(context);
        }
    }
}
