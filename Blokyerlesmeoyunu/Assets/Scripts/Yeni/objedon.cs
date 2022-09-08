using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objedon : MonoBehaviour
{
    public tutma tutma;
    private int sayi;
    void Start()
    {

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sayi++;
        }

        if (sayi == 2)
        {
            transform.Rotate(0, 0, 90);
            tutma.dön();
            sayi = 0;
        }
    }


    void Update()
    {

    }
}
