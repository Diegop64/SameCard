using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

public class Contador : MonoBehaviour
{
    public static int numeroInicial = 0;
    public static int numeroDescartadas = 0;
    public Animator animacion;
    public GameObject BlackCard;
    public TMPro.TextMeshProUGUI text;
   // public GameObject[] objects;
    public List<GameObject> monton;
    public GameObject[] montones;
    public static int montonIdx;
    public int orderIdx = 1000000;
    int mc;
    public GameObject[] objects;
    public UnityEngine.Object[] objs;



     void Start()
     {
        crearCartaNegra();
        objs = Resources.LoadAll("CardsObjects");
        animacion = GetComponent<Animator>();
        monton = new List<GameObject>();
        objects = new GameObject[objs.Length];
       // objects = new GameObject[12];
       // objects[0] = C1G; objects[1] = C1O; objects[2] = C1R; objects[3] = C2G; objects[4] = C2O; objects[5] = C2P; objects[6] = C3R; objects[7] = C3B; objects[8] = C3P;
       // objects[9] = C4B; objects[10] = C4O; objects[11] = C4P;
      
        for (int i=0; i<objs.Length; i++)
        {
            objects[i] = (GameObject) objs[i];
        }
        montonIdx = 0;
        


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
        if (montonIdx == 0) text.text = "M: " + numeroInicial + " D: " + numeroDescartadas;
        else text.text = "M: " + numeroInicial + " D: " + numeroDescartadas + "\n \n" + montonIdx;

        mc = monton.Count - 1;
       /* if (numeroDescartadas == 0 && numeroInicial > 0)
        {
            numeroInicial--;
            crearCarta();
            numeroDescartadas++;
        }*/
    }

    public void crearCarta()
    {
        if (numeroInicial > 0  && montonIdx == 0)
        {
            int num = UnityEngine.Random.Range(0, objects.Length-1);
            
            GameObject ncarta = Instantiate(objects[num], objects[num].transform.position, objects[num].transform.rotation) as GameObject;
            ncarta.GetComponent<SpriteRenderer>().sortingOrder = orderIdx;
            orderIdx++;
            monton.Add(ncarta);
        }
    }

   /* public void crearCarta()
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
        

    }*/
    void descartarTodas()
    {
        GameObject[] descartes = GameObject.FindGameObjectsWithTag("Cards");
        for (int n=0; n < descartes.Length; n++)
        {
            Destroy(descartes[n]);
        }
        montonIdx = 0;
    }
    public void crearCartaNegra()
    {
        GameObject ncarta = Instantiate(BlackCard, BlackCard.transform.position, BlackCard.transform.rotation) as GameObject;
        ncarta.GetComponent<SpriteRenderer>().sortingOrder = orderIdx;
        orderIdx++;
        monton.Clear();
    }

    public void BuscarAnterior()
    {
        if (numeroDescartadas > 1 && montonIdx<mc)
        {
            monton[mc-montonIdx].SendMessage("CentroIzquierda");
            monton[mc-montonIdx-1].SendMessage("DerechaCentro");
            montonIdx++;
            Debug.Log("The index is: " + montonIdx + " The size of the List is: " + monton.Count);
        }
    }

    public void VolverAnterior()
    {
        if (montonIdx > 0 )
        {
            monton[mc-montonIdx].SendMessage("CentroDerecha");
            monton[mc-montonIdx+1].SendMessage("IzquierdaCentro");
            montonIdx--;
        }
    }

  /*  public void anyadirCartas()
    {
        try
        {

            int añadir = int.Parse(moreCards.text);
            numeroInicial += añadir;
        }
        catch ( InvalidCastException e) { }

    }*/
}
