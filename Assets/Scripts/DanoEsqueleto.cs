using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanoEsqueleto : MonoBehaviour
{

    int vida = 1;
    
    private Animator animatorEsqueleto;
    public Text puntaje;

    // Start is called before the first frame update
    void Start()
    {
        animatorEsqueleto = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Disparo")
        {
            int puntos;
            puntos = int.Parse(puntaje.text);

            if (vida == 3)
            {
                animatorEsqueleto.SetTrigger("muerte");
                
                Destroy(gameObject, 5f);

                puntos++;
                puntaje.text = "" + puntos.ToString();
                
            }
            else
            {
                animatorEsqueleto.SetTrigger("damage");
                vida++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
