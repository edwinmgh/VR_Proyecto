using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanoPersonaje : MonoBehaviour
{
    int vida = 1;

    private Animator animatorPersonaje;
    public Text puntaje;

    // Start is called before the first frame update
    void Start()
    {
        animatorPersonaje = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Disparo")
        {
            int puntos;
            puntos = int.Parse(puntaje.text);

            if (vida == 5)
            {
                animatorPersonaje.SetTrigger("muerte");

                Destroy(gameObject, 5f);

                puntos=puntos+10;
                puntaje.text = "" + puntos.ToString();

            }
            else
            {
                animatorPersonaje.SetTrigger("damage");
                vida++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}