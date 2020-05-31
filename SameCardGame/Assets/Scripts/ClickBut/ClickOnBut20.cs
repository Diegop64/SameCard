using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnBut20 : MonoBehaviour
{
    public void event10()
    {
        Contador.numeroInicial = 20;
        SceneManager.LoadScene("SampleScene");
    }
}
