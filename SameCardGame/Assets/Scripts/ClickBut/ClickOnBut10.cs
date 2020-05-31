using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnBut10 : MonoBehaviour
{
  public void event10()
    {
        Contador.numeroInicial = 10;
        SceneManager.LoadScene("SampleScene");
    }
}
