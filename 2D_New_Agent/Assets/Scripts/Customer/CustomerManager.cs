using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public static Customer instance;  
    public Customer oldMan = new Customer();
    public Customer azumma = new Customer();
    public Customer kid = new Customer();

    public void CutomerInfoUpdate(CustomerInfo _customerInfo)
    {
        System.Random rand = new System.Random();
        _customerInfo.m_dTemper = Math.Round(rand.Next(36, 37) + rand.NextDouble(), 1);
        _customerInfo.m_bMask = Convert.ToBoolean(rand.Next(0, 1));
    }

    public void Start()
    {
        azumma.temperture = 0f;
        azumma.bvaccine = false;

        oldMan.temperture = 0f;
        oldMan.bvaccine = false;

        kid.temperture = 0f;
        kid.bvaccine = false;
    }
    void Update()
    {

    }
}

public class Customer
{
    public bool bmasked;
    public float temperture;
    public bool bvaccine;
}
