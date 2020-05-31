using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCript : MonoBehaviour
{
    public Animator animacion;
    GameObject controlador;
    bool centro = true;
   // int i = 0;
    void Start ()
    {
       // rb2d = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
        controlador = GameObject.Find("Contador");
    }


    
        void OnMouseDown()
    {

            if (Input.GetMouseButton(0) && Contador.montonIdx==0 && centro)
            {
                Debug.Log("Pressed left click, casting ray.");
                CastRay();
            }
        }

        void CastRay()
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, transform.position);
            if (hit.collider != null)
            {
               Debug.Log("Hit: " + hit.collider.gameObject.name);
              if (Contador.numeroInicial < 1) return;
              Contador.numeroDescartadas += 1;
    
              controlador.SendMessage("crearCarta");
    
              if (Contador.numeroInicial != 0)
                 {
                   CentroDerecha();
    
                     // Destroy(this.gameObject);  
                 }
               Contador.numeroInicial -= 1;

            }
        }

        

        /*
    public void OnMouseDown()
    {
        if (primerPlano)
        {
            if (Contador.numeroInicial < 1) return;
            Contador.numeroDescartadas += 1;

            controlador.SendMessage("crearCarta");

            if (Contador.numeroInicial != 0)
            {
                animar();

                // Destroy(this.gameObject);  
            }
            Contador.numeroInicial -= 1;
        }
    }
    */
    void CentroDerecha()
    {
        centro = false;
        animacion.Play("CentroADerecha");
    }

     public void DerechaCentro()
    {
        centro = true;
        animacion.Play("DerechaACentro");
    }

    public void IzquierdaCentro()
    {
        centro = true;
        animacion.Play("IzquierdaACentro");
        Debug.Log("AAAAAAAAAAAAAAAA");
    }

    public void CentroIzquierda()
    {
        centro = false;
        animacion.Play("CentroAIzquierda");
    }
    

   
}
