using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;      // 손님 이름 nametext
    public Text dialogueText;  // 대화 내용 text
    public Animator Animator;  // text창을 끄고 키는 애니매이터

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();    
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Animator.SetBool("IsOpen",true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));  //코루틴 시작.
    }

    IEnumerator TypeSentence(string sentence)  //글자 하나 하나를 입력하듯이 출력하는 코루틴.
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        Animator.SetBool("IsOpen", false);   //dialogue를 끝낼때 사용하는 애니메이션
    }
}
