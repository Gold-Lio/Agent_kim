using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
  
    public void HideUI()
    {

    }

    void ShowDialogue(Dialogue[] dialogues)
    {
        dialogues = dialogues;
    }

    void Interact()
    {
        this.transform.GetComponent<InteractionEvent>().GetDialogues();
    }


}
