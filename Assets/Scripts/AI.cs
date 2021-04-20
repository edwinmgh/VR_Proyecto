using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AI : MonoBehaviour
{

    public GameObject Target;
    public GameObject Personaje;
    public float distanciaDetener;
    public Text puntaje;
    private float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(Target.GetComponent<Transform>().position, Personaje.GetComponent<Transform>().position);
        //Debug.Log(distancia);
        if(distancia > 100)
        {
            Personaje.GetComponent<Animator>().SetBool("caminar", false);
            Personaje.GetComponent<NavMeshAgent>().isStopped = true;
            Personaje.GetComponent<NavMeshAgent>().ResetPath();
        }
        else
        {
            if (distancia < distanciaDetener)
            {
                Personaje.GetComponent<Animator>().SetBool("caminar", false);
                Personaje.GetComponent<NavMeshAgent>().isStopped = true;
                Personaje.GetComponent<NavMeshAgent>().ResetPath();
                Personaje.GetComponent<Animator>().SetBool("atacar", true);
                if (tiempo < Time.time)
                {
                    tiempo = Time.time + 1;
                    float puntos = float.Parse(puntaje.text) - 10;
                    puntaje.text = "" + puntos;
                }
            }
            else
            {
                Personaje.GetComponent<Animator>().SetBool("atacar", false);
                Personaje.GetComponent<Animator>().SetBool("caminar", true);
                Personaje.GetComponent<NavMeshAgent>().SetDestination(Target.GetComponent<Transform>().position);
            }
        }
    }
}
