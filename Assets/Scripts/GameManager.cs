using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public string mensajeDinamico;
    private string mensajeEstatico;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Acabas de iniciar");
        mensajeEstatico = "Hola Mundo";
        Debug.Log(mensajeEstatico);
        Debug.Log(mensajeDinamico);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
