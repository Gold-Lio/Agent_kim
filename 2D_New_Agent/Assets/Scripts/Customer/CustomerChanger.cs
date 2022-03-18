using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerChanger : MonoBehaviour
{
    public Sprite[] spr;
    public void Start()
    {
        Init_UI();
    }


    void Init_UI()
    {
        button_random.onClick.RemoveAlisteners();

    }

}
