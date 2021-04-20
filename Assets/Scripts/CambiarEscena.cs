using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{

    public string esecena;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            SceneManager.LoadScene(esecena);
        }
    }
}
