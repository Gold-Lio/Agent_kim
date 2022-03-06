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


    bool isDialogue = false;  //��ȭ�� �⺻ �� false

    public void ShowDialogue(Dialogue[] p_dialogues)
    {
        txt_Dialogue.text = "";  //��ȭ, �̸� â�� �ʱ�ȭ�Ѵ�.
        txt_Name.text = "";
        dialogues = p_dialogues;
        SettingUI(true);
    }

    void SettingUI(bool p_flag)
    {
        go_DialogueBar.SetActive(p_flag);   //��ȭ Ȱ��ȭ,�Լ��� bool�� �Ķ���� ����.
        go_DialogueNameBar.SetActive(p_flag);
    }

}
//    public Text nameText;      // �մ� �̸� nametext
//    public Text dialogueText;  // ��ȭ ���� text
//   // public Animator Animator;  // â�� ���� Ű�� �ִϸ�����

//    private Queue<string> sentences;

//    void Start()
//    {
//        sentences = new Queue<string>();
//    }
//    public void StartDialogue(Dialogue dialogue)  //��ȭ�� �����ϴ� �Լ�
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
//            StartCoroutine(TypeSentence(sentence));  //�ڷ�ƾ ����.
//        }

//        IEnumerator TypeSentence(string sentence)  //���� �ϳ� �ϳ��� �Է��ϵ��� ����ϴ� �ڷ�ƾ.
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
//           // Animator.SetBool("IsOpen", false);   //dialogue�� ������ ����ϴ� �ִϸ��̼�
//        }
//    }
//}
