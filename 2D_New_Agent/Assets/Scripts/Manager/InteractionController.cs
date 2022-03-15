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

    //private void Update()
    //{
    //    DialogueAction();
    //}

    //��ȭ�� �ۿ��� �� Update��.

    public void DialogueAction()
    {
        StartCoroutine(Customer());
    }

    IEnumerator Customer(){  //Ư�� ������ �����Ҷ����� ����Ϳ��� ������� ���ö�����       //Ŀ���͸Ӱ� ������
    {
            yield return new WaitForSeconds(0.1f);
            //���� ������� �ϰ� , ������ ���(���� Ȥ�� ����)�� ���� �� ����ȭ�� UI�� ���� �Ѵ�.  �����Ѵٸ� ���� ���� UI...! 
            theDM.ShowDialouge();

           // transform.GetComponent<InteractionEvent>().GetDialogues()
        }
    }
}
