using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{

    bool isContact = false;

    DialogueManager theDM; // DialogueManager�� ������ ����

    private void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
    }

    private void Update()
    {
        ShowDialogue(dialogus);
        theDM.ShowDialogue();
    }

    void ShowDialogue(Dialogue[] dialogues)
    {
        dialogues = dialogues;
        isContact = true;
        this.transform.GetComponent<InteractionEvent>().GetDialogues();
        StartCoroutine("Customer"); 
    }

    void Interact()
    {
      
        StartCoroutine("Customer");
    }

    IEnumerator WaitOneSecend(){  //Ư�� ������ �����Ҷ����� ����Ϳ��� ������� ���ö�����       //Ŀ���͸Ӱ� ������
    {
        if ( ) // yes or no�� �������� 
            theDM.ShowDialouge(transform.GetComponent<InteractionEvent>().GetDialogues());    //���� ������� �ϰ� , ������ ���(���� Ȥ�� ����)�� ���� �� ����ȭ�� UI�� ���� �Ѵ�.  �����Ѵٸ� ���� ���� UI...! 
            
            
            
            
            yield return new WaitForSeconds(0.1f);
        }
    }
}
