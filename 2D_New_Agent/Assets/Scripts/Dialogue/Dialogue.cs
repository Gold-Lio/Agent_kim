using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // �����͸� ���ķ� ���, �� �ν�����â���� ���� ����
public class Dialogue
{
    [Tooltip("��� ����")]
    public string contexts;
}

[System.Serializable]
public class DialogueEvent
{
    public string name;  //��ȭ�̺�Ʈ�� �̸����

    public Vector2 line; // ���° ��~~��ȭ�����ϴ� ����  x���� y������ ��ȭ�� �����س��� ����

    public Dialogue[] dialogues;


}