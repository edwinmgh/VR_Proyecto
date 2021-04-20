using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMa : MonoBehaviour
{

    public Text puntaje;
    public Text vidas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float puntos = float.Parse(puntaje.text);
        if (puntos <= 0)
        {
            Over.show();
        }

        float vida = float.Parse(vidas.text);
        if (vida == 200)
        {
            Win.show();
        }
    }
}
