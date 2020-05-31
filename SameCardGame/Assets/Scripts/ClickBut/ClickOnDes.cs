using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnDes : MonoBehaviour
{
    public Contador cont;
    GameObject cartaNegraAnterior;
    public void Win()
    {
        // if (cartaNegraAnterior = GameObject.Find("BlackCard(Clone)"))   //|| (cartaNegraAnterior = GameObject.Find("RedCard(Clone)")) || (cartaNegraAnterior = GameObject.Find("BlueCard(Clone)")) || (cartaNegraAnterior = GameObject.Find("GreenCard(Clone)")))

        cont.SendMessage("descartarTodas");
        Contador.numeroDescartadas = 0;
        cont.SendMessage("crearCartaNegra");
        
    }
}
