using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class Contador : MonoBehaviour
{
    public static int numeroInicial = 0;
    public static int numeroDescartadas = 0;
    public GameObject RedCard, GreenCard, BlueCard,card1;
    public TMPro.TextMeshProUGUI text;
    public TMP_InputField field;


     void Start()
     {
        crearCarta();
     }

   /*   void OnGUI()
      {
          GUI.skin.font = fuente;
          GUI.contentColor = Color.white;
          numeroCartas = GUI.TextField(new Rect(219, 100, 100, 20), numeroCartas, 2);

          GUI.contentColor = Color.magenta;

          if(GUI.Button(new Rect(220,130,100,30), "Introducir numero"))
          {
              PlayerPrefs.SetString("nombre", numeroCartas);
             // Application.LoadLevel(3);
          }


      }*/
    void Update()
    {
        text.text = "M: " + numeroInicial + " D: " + numeroDescartadas;
    }

    public void crearCarta()
    {
        if (numeroInicial > 0)
        {
            int num = UnityEngine.Random.Range(1, 4);
            if (num == 1)
            {
                // GameObject carta1 = 
                _ = Instantiate(RedCard, card1.transform.position, card1.transform.rotation) as GameObject;

            }
            else if (num == 2)
            {
                _ = Instantiate(GreenCard, card1.transform.position, card1.transform.rotation) as GameObject;
            }
            else
            {
                _ = Instantiate(BlueCard, card1.transform.position, card1.transform.rotation) as GameObject;
            }
            
        }
        

    }

    public void anyadirCartas()
    {
        try
        {

            int añadir = int.Parse(moreCards.text);
            numeroInicial += añadir;
        }
        catch ( InvalidCastException e) { }

    }
}
