using System;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    //estado de enemigo: patrulla, deteccion, persecucion
    String estado = "patrulla";

    public float distanciaPatrulla = 2.0f;

    public float velocidadPatrulla = 0.02f;

    Vector3 posicionInicial;
    Vector3 posicionLimitIzq, posicionLimitDer;


    void Start()
    {
        posicionInicial = transform.position;
        posicionLimitIzq = new Vector3(posicionInicial.x - distanciaPatrulla, posicionInicial.y, 0);
        posicionLimitDer = new Vector3(posicionInicial.x + distanciaPatrulla, posicionInicial.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
       if(estado == "patrulla")
       {
         //si limite derecha
         if(transform.position >= posicionLimitDer.x)
            {
              transform.Translate(velocidadPatrulla, 0, 0);  

            }
            else
            {
                transform.Translate(velocidadPatrulla, 0, 0);  
            }
        
        transform.Translate(velocidadPatrulla, 0, 0);

       }




    }

  void OnTriggerEnter2D(Collider2D col)
  {
    Debug.Log(col.gameObject.name);
    
    if (col.gameObject.name == "bala")
    {
        Debug.Log("Enemigo eliminado");
        Destroy(col.gameObject, 0.1f);
        Destroy(this.gameObject, 0.1f);
    }

  }
 
}