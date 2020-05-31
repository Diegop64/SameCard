using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnAnya : MonoBehaviour
{

    public Contador cont;

    public TMPro.TMP_InputField moreCards;

        public void Lose()
        {
        int añadir = 0;
        try
        {
            añadir = int.Parse(moreCards.text);
            
        }
        catch (InvalidCastException) { Debug.Log("Mal"); }
        Contador.numeroInicial += añadir;
      //  if (Contador.numeroInicial == 0) cont.SendMessage("crearCarta");
    }


}
