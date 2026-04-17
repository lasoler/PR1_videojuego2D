using UnityEngine;
using UnityEngine.InputSystem;
public class movpersonaje : MonoBehaviour
{


 public float velocidad = 0.5f;
 public float impulsoSalto= 10.0f;
public Vector3 inicioPersonaje = new Vector3 (1,2,3);


Rigidbody2D rb;

Animator controlAnimacion;

bool puedoSaltar = false;

GameObject respawn;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     this.transform.position = inicioPersonaje;
     rb = GetComponent<Rigidbody2D>();
     controlAnimacion = GetComponent<Animator>();
     respawn = GameObject.Find("respawn");
     transform.position = respawn.transform.position;


     
   
    }


    // Update is called once per frame
    void Update()
    {
       
       //controlAnimacion.SetBool("activaCamina", true);
     
     
     
     
      Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
     
      this.transform.Translate(moveInput.x * velocidad, moveInput.y * velocidad, 0);
     
      if(moveInput.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        } else if (moveInput.x > 0)
        {
           this.GetComponent<SpriteRenderer>().flipX = false;


        }

    //Animacion caminando
     if (moveInput.x != 0)
        {
            controlAnimacion.SetBool("activaCamina", true);
        }
        else
        {
            controlAnimacion.SetBool("activaCamina", false);
        }

        //SALTO


         bool salto = InputSystem.actions["Jump"]. WasPressedThisFrame();


         if(salto == true)
         {
            Debug.Log("Salto");
            rb.AddForce(transform.up * impulsoSalto, ForceMode2D.Impulse);
            this.GetComponent<SpriteRenderer>().color = Color.red;
         }
         else
         {
            this.GetComponent<SpriteRenderer>().color = Color.white;
         }
       
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down * 0.5f);
        Debug.DrawRay(transform.position, Vector2.down * 0.5f, Color.red);


        if(hit.collider == true)
        {
            puedoSaltar = true;
        }
        else
        {
            puedoSaltar = false;
     
        }
       
 
}
 void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger con; " + col.gameObject.name);

        if(col.gameObject.name == "dead")
        {
            GameManager.vidas -= 1;
            transform.position = respawn.transform.position;
        }
        if(col.gameObject.name == "coin")
        {
            Debug.Log("puntos: " + GameManager.puntos);
            GameManager.puntos += 10;
            col.gameObject.GetComponent<Animator>().SetBool("obtenerCoin", true);
            Destroy(col.gameObject, 2.0f);
        }
    }
}

/* 

oeuhgriuh3eiurjfhniuoh

*/

