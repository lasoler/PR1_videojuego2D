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

    bool dirPatrullaDer = true;

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

         if(transform.position.x >= posicionLimitDer.x)
            {
              dirPatrullaDer = false;  

            }
            if(transform.position.x <= posicionLimitIzq.x)
            {
                dirPatrullaDer = true; 
            }
        
         //si limite derecha
         if(dirPatrullaDer == true)
            {
              transform.Translate(velocidadPatrulla, 0, 0);  

            }
            else
            {
                transform.Translate(velocidadPatrulla*-1, 0, 0);  
            }
        
    

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