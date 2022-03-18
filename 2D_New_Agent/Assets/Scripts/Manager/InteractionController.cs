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
 
    public void DialogueAction()
    {
        StartCoroutine(Customer());
    }

    IEnumerator Customer(){  //Ư�� ������ �����Ҷ����� ����Ϳ��� ������� ���ö�����       //Ŀ���͸Ӱ� ������
    {
            //���� ������� �ϰ� , ������ ���(���� Ȥ�� ����)�� ���� �� ����ȭ�� UI�� ���� �Ѵ�.  �����Ѵٸ� ���� ���� UI...! 
            theDM.ShowDialouge(transform.GetComponent<InteractionEvent>().GetDialogues());

            // position ��Ȯ����ġ.. ��� �޾ƿò���? �װ� ���ؾ��� ��Ȯ�� ��ġ�� �ȾƳ־�����ϴ°�?

            yield return new WaitForSeconds(0.1f);

            //
        }
    }
}
