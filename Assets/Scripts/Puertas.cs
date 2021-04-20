using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puertas : MonoBehaviour
{
    public Text puntaje;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int puntos;
            puntos = int.Parse(puntaje.text);

            puntos = puntos + 20;
            puntaje.text = "" + puntos.ToString();
            Destroy(gameObject, 0f);
            if (puntos == 360)
            {
                Win.show();
            }
        }
    }
}
