using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTogame : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("In_Game");
    }
}
