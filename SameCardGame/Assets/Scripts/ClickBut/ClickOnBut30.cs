using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnBut30 : MonoBehaviour
{
    public void event10()
    {
        Contador.numeroInicial = 30;
        SceneManager.LoadScene("SampleScene");
    }
}
