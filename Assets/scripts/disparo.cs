using UnityEngine;
using UnityEngine.InputSystem;

public class disparo : MonoBehaviour
{
    public GameObject disparar;
     // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
     {
        
     }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, 0, 0.5f);
       disparar.transform.Translate(0.01f, 0, 0);
    }
    
}
