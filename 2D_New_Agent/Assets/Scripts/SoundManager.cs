using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�Ҹ��Ѱ��
    public void SoundToggle(bool soundon)
    {
        if (soundon)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
    //�����Ѱ��
    public void VibToggle(bool vibon)
    {
        if (vibon)
        {
            
        }
        else
        {
            
        }
    }
}
