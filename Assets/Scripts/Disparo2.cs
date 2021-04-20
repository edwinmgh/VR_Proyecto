using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo2 : MonoBehaviour
{

    public float velocidadDisparo;
    private Rigidbody rb;
    public Transform explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * velocidadDisparo);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
