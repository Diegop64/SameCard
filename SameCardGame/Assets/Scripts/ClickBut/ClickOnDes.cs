using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnDes : MonoBehaviour
{
   

    public void Win()
    {
        Contador.numeroDescartadas = 0;
        cont.SendMessage("crearCartaNegra");
    }
}
