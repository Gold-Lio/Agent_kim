using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �����ͺ��̽��� ����� ���� ��� ��ũ��Ʈ�� ������ �� 
///
/// </summary>
[System.Serializable]
public class InteractionEvent : MonoBehaviour
 {
    [SerializeField] DialogueEvent dialogue;
    //���° �ٺ��� ���° ���� �������� �������ִ� interactionEvent
    public Dialogue[] GetDialogues()
    {
        dialogue.dialogues = DatabaseManager.instance.GetDialogue((int)dialogue.line.x);
        return dialogue.dialogues;
    }
}
