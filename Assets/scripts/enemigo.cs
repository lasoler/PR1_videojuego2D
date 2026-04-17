using UnityEngine;

public class enemigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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