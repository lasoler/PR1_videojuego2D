using UnityEngine;

public class parallax : MonoBehaviour
{
    public float velocidadParallax = 1f;
    public GameObject Personaje;
    public GameObject camara;
    void Start()
    {
        camara = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camara.transform.position.x, camara.transform.position.y, camara.transform.position.z);
    }
}
