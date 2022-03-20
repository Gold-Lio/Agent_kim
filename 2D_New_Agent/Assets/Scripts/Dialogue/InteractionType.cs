using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionType : MonoBehaviour
{
    public bool isCustomer;

    [SerializeField] string interactionName;

    public string GetName()
    {
        return interactionName;
    }
}

