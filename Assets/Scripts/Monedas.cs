using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monedas : MonoBehaviour
{
    public Text puntaje;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int puntos;
            puntos = int.Parse(puntaje.text);
            Destroy(gameObject, 0f);

            puntos=puntos+10;
            puntaje.text = "" + puntos.ToString();
            if (puntos == 200)
            {
                Over.show();
            }
        }
    }
}
