using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCript : MonoBehaviour
{
    public Animator animacion;
    GameObject controlador;
    void Start ()
    {
       // rb2d = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
        controlador = GameObject.Find("Contador");
 
    }

   /* void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;// = Physics2D.Raycast(transform.position,);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                   animacion.Play("CardChanging");
                Debug.Log(hit.collider.name);
         
            }
        }
    }*/

        public void OnMouseDown()
    {
        //if (Contador.numeroInicial > 0) { 
        Contador.numeroDescartadas += 1;
        Contador.numeroInicial -= 1;
        controlador.SendMessage("crearCarta",0);
        animacion.Play("CardChanging");
       // }
        //Destroy(this.gameObject);

    }
   
}
