using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // �����͸� ���ķ� ���, �� �ν�����â���� ���� ����
public class Dialogue
{
    [Tooltip("��� ġ�� ĳ������ �̸�")]
    public string name;

    [Tooltip("��� ����")]
    [TextArea(2,10)]
    public string[] sentences;
    internal string[] contexts;
}

[System.Serializable]
public class DialogueEvent
{
    public string name; //�̺�Ʈ �̸� ���

    public Vector2 line; // ���° ��~~��ȭ�����ϴ� ����
    
    [SerializeField]
    public Dialogue[] dialogues;
}