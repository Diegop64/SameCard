using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeLeftRight : MonoBehaviour
{
    // Start is called before the first frame update
    public Contador contador;

    public void seeLeft()
    {
        contador.SendMessage("BuscarAnterior");
    }
}
