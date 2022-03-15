using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    bool isContact = false;

    DialogueManager theDM; // DialogueManager를 참조할 변수

    private void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
    }

    //private void Update()
    //{
    //    DialogueAction();
    //}

    //대화의 작용이 들어간 Update문.

    public void DialogueAction()
    {
        StartCoroutine(Customer());
    }

    IEnumerator Customer(){  //특정 조건을 만족할때까지 모니터에서 결과값이 나올때까지       //커스터머가 있을때
    {
            yield return new WaitForSeconds(0.1f);
            //고객을 사라지게 하고 , 조건의 결과(실패 혹은 성공)에 따라 를 바탕화면 UI를 변경 한다.  실패한다면 게임 실패 UI...! 
            theDM.ShowDialouge();

           // transform.GetComponent<InteractionEvent>().GetDialogues()
        }
    }
}
