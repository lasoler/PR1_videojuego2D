using UnityEngine;
using UnityEngine.InputSystem;

public class arma : MonoBehaviour
{
   public GameObject disparo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool disparar = InputSystem.actions["Attack"]. WasPressedThisFrame(); 

       if (disparar)
         {
          Instantiate(disparo, transform.position, Quaternion.identity);
         }
    }
}

