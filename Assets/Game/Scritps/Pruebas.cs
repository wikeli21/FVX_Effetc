using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{

    [Tooltip("Velocidad m�xima a la que el objeto puede moverse.")]
    public float maxSpeed = 10.0f;

    [Tooltip("Objeto que seguir� el personaje cuando est� en movimiento.")]
    public GameObject followObject;
    [Tooltip("hola")]
    private float c;
    // Start is called before the first frame update
    void Start()
    {

        c = Mathf.Lerp(0, 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("el resultado es: " + c);
    }
}
