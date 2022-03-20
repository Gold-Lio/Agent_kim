using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    bool isContact = false;

    DialogueManager theDM; // DialogueManager�� ������ ����

    public GameObject customer;

    private void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
        customer = GetComponent<GameObject>();
        // theDM = transform.GetComponent<InteractionEvent>().GetDialogues();  //�迭�� �׳����� ���ٲ۴�...
    }
 
    public void DialogueAction()
    {
        StartCoroutine(Customer());
    }

    IEnumerator Customer()
    {        //Ư�� ������ �����Ҷ����� ����Ϳ��� ������� ���ö�����       //Ŀ���͸Ӱ� ������
            customer.SetActive(true);
            //���� ������� �ϰ� , ������ ���(���� Ȥ�� ����)�� ���� �� ����ȭ�� UI�� ���� �Ѵ�.  �����Ѵٸ� ���� ���� UI...! 
            theDM.ShowDialouge(customer.transform.GetComponent<InteractionEvent>().GetDialogues()) ;
            // position ��Ȯ����ġ.. ��� �޾ƿò���? �װ� ���ؾ��� ��Ȯ�� ��ġ�� �ȾƳ־�����ϴ°�?
            yield return new WaitForSeconds(0.1f);
    }
}
