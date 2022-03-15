using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject go_DialogueBar;
    [SerializeField] Text txt_Dialogue;

    Dialogue[] dialogues;

    bool isDialogue = false;

    InteractionController theIC;

    void Start()
    {
        theIC = FindObjectOfType<InteractionController>();
    }

    public void ShowDialouge(Dialogue[] p_dialogues)
    {
        txt_Dialogue.text = "";
        // theIC.HideUI;
        dialogues = p_dialogues;
        SettingUI(true);
    }

    void SettingUI(bool p_flag)
    {
        go_DialogueBar.SetActive(p_flag);
    }

}