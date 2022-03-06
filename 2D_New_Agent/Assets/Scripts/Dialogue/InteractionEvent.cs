using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractionEvent : MonoBehaviour
{
    [SerializeField] DialogueEvent dialogues;

    DialogueManager customer_DM;

    private void Start()
    {
        customer_DM = FindObjectOfType<DialogueManager>();
    }

    void Interact()
    {
        StartCoroutine(CustomerDialogue());
    }

    IEnumerator CustomerDialogue()
    {
        yield return null;
        customer_DM.ShowDialogue();
    }
}

