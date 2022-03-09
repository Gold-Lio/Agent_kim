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
        temp.text = "온도 : ";// + Customer;
        mask.text = "마스크 : ";// + ;
        vacin.text = "백신 여부 :";// + ;

        if (!isGameover)
        {
            if (bvacinnate)
            {
                if (bmask)
                {
                    if (temperture < 37.5f)
                    {
                        Debug.Log("통과!");
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
