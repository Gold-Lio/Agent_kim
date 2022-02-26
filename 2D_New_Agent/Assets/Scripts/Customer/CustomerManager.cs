using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public static Customer instance;
    public Customer oldMan = new Customer();
    public Customer azumma = new Customer();
    public Customer kid = new Customer();

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
    public bool bvaccine;}
