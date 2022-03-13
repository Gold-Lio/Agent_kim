using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 데이터베이스에 저장된 실제 대사 스크립트를 꺼내올 것 
///
/// </summary>
[System.Serializable]
public class InteractionEvent : MonoBehaviour
{
    [SerializeField] DialogueEvent dialogue;

    public Dialogue[] GetDialogues()
    {
        dialogue.dialogues = DatabaseManager.instance.GetDialogues();
    }
}
