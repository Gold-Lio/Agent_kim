using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    bool isContact = false;

    DialogueManager theDM; // DialogueManager를 참조할 변수

    public GameObject customer;

    private void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
        customer = GetComponent<GameObject>();
        // theDM = transform.GetComponent<InteractionEvent>().GetDialogues();  //배열을 그냥으로 못바꾼다...
    }
 
    public void DialogueAction()
    {
        StartCoroutine(Customer());
    }

    IEnumerator Customer()
    {        //특정 조건을 만족할때까지 모니터에서 결과값이 나올때까지       //커스터머가 있을때
            customer.SetActive(true);
            //고객을 사라지게 하고 , 조건의 결과(실패 혹은 성공)에 따라 를 바탕화면 UI를 변경 한다.  실패한다면 게임 실패 UI...! 
            theDM.ShowDialouge(customer.transform.GetComponent<InteractionEvent>().GetDialogues()) ;
            // position 정확한위치.. 어디에 받아올꺼야? 그걸 정해야함 정확히 위치에 꽂아넣어줘야하는가?
            yield return new WaitForSeconds(0.1f);
    }
}
