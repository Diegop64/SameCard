using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeRightCard : MonoBehaviour
{
    public Contador contador;
    public void seeRight()
    {
        contador.SendMessage("VolverAnterior");
    }
}
