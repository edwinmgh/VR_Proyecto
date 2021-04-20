using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{

    public GameObject GameOverText;
    public static GameObject GameOverStatic;

    // Start is called before the first frame update
    void Start()
    {
        Objetivos.GameOverStatic = GameOverText;
        Objetivos.GameOverStatic.gameObject.SetActive(true);
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
