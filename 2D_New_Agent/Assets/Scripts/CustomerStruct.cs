using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CustomerInfo
{
    public int m_nID;
    public double m_dTemper;
    public bool m_bMask;
}

public class CustomerStruct : MonoBehaviour
{
    public CustomerManager customerManager;
    public CustomerInfo customerInfo;

    public int m_nID;

    public void Awake()
    {
        customerManager = new CustomerManager();
        customerInfo = new CustomerInfo();

        customerInfo.m_nID = m_nID;
        customerManager.CutomerInfoUpdate(customerInfo);
    }
}