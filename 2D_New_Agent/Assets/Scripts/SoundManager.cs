using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //家府难绊阐
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
    //柳悼难绊阐
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
