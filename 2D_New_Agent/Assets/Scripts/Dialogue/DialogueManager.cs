using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject go_DialogueNameBar;
    [SerializeField] GameObject go_DialogueBar;

    [SerializeField] Text txt_Dialogue;
    [SerializeField] Text txt_Name;

    Dialogue[] dialogues;


    bool isDialogue = false;  //대화의 기본 값 false

    public void ShowDialogue(Dialogue[] p_dialogues)
    {
        txt_Dialogue.text = "";  //대화, 이름 창을 초기화한다.
        txt_Name.text = "";
        dialogues = p_dialogues;
        SettingUI(true);
    }

    void SettingUI(bool p_flag)
    {
        go_DialogueBar.SetActive(p_flag);   //대화 활성화,함수의 bool값 파라미터 적용.
        go_DialogueNameBar.SetActive(p_flag);
    }

}
//    public Text nameText;      // 손님 이름 nametext
//    public Text dialogueText;  // 대화 내용 text
//   // public Animator Animator;  // 창을 끄고 키는 애니매이터

//    private Queue<string> sentences;

//    void Start()
//    {
//        sentences = new Queue<string>();
//    }
//    public void StartDialogue(Dialogue dialogue)  //대화를 시작하는 함수
//    {
//       // Animator.SetBool("IsOpen", true);
//        nameText.text = dialogue.name;
//        sentences.Clear();

//        foreach (string sentence in dialogue.sentences)
//        {
//            sentences.Enqueue(sentence);
//        }
//        DisplayNextSentence();
//    }

//    public void DisplayNextSentence()
//    {
//        if (Input.GetKeyDown("space"))
//           {
//            if (sentences.Count == 0)
//            {
//                EndDialogue();
//                return;
//            }
//            string sentence = sentences.Dequeue();
//            StopAllCoroutines();
//            StartCoroutine(TypeSentence(sentence));  //코루틴 시작.
//        }

//        IEnumerator TypeSentence(string sentence)  //글자 하나 하나를 입력하듯이 출력하는 코루틴.
//        {
//            dialogueText.text = "";
//            foreach (char letter in sentence.ToCharArray())
//            {
//                dialogueText.text += letter;
//                yield return null;

//            }
//        }
//        void EndDialogue()
//        {
//           // Animator.SetBool("IsOpen", false);   //dialogue를 끝낼때 사용하는 애니메이션
//        }
//    }
//}
