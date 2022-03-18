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

    public void ShowDialouge(Dialogue[] p_dialogues)  //고객의 대화박스  (Dialogue[] p_dialogues)
    {
        txt_Dialogue.text = "";
        dialogues = p_dialogues;
        DialogueUI(true);
    }

    void DialogueUI(bool p_flag)
    {
        go_DialogueBar.SetActive(p_flag);
    }

    void CustomerImg ()
    {

    }

}