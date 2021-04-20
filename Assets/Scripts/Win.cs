using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinText;
    public static GameObject WinStatic;

    // Start is called before the first frame update
    void Start()
    {
        Win.WinStatic = WinText;
        Win.WinStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void show()
    {
        Win.WinStatic.gameObject.SetActive(true);
    }
}
