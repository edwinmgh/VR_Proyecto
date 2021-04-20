using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{

    public int tiempo = 500;
    public Text time;
    public float tiempod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo == 0)
        {
            Over.show();
        }
        else if(tiempod < Time.time)
        {
            tiempod = Time.time + 1;
            tiempo = tiempo -1;
            time.text = "" + tiempo.ToString();
        }
    }
}
