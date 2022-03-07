using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DebugTalkData : MonoBehaviour
{
    public string eventName;
    public Dialogue[] dialogues;

    public DebugTalkData(string name, Dialogue[] td)
    {
        eventName = name;
        dialogues = td;
    }
}
