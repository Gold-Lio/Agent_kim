using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorManager : MonoBehaviour
{
    public bool bvacinnate = false;
    public bool bmask = false;
    public float temperture = 0f;

    public Text vacin, mask, temp;
    private bool isGameover = false;

    public void Action()
    {
        temp.text = "�µ� : ";// + Customer;
        mask.text = "����ũ : ";// + ;
        vacin.text = "��� ���� :";// + ;

        if (!isGameover)
        {
            if (bvacinnate)
            {
                if (bmask)
                {
                    if (temperture < 37.5f)
                    {
                        Debug.Log("���!");
                    }
                }
            }
            else
            {
                isGameover = true;
            }
        }
    }
}
