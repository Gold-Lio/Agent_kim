using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;      // �մ� �̸� nametext
    public Text dialogueText;  // ��ȭ ���� text
    public Animator Animator;  // textâ�� ���� Ű�� �ִϸ�����

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
        StartCoroutine(TypeSentence(sentence));  //�ڷ�ƾ ����.
    }

    IEnumerator TypeSentence(string sentence)  //���� �ϳ� �ϳ��� �Է��ϵ��� ����ϴ� �ڷ�ƾ.
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
        Animator.SetBool("IsOpen", false);   //dialogue�� ������ ����ϴ� �ִϸ��̼�
    }
}
