using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Yerlesme : MonoBehaviour
{
    public bool y1, y2, y3, y4;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonUp(1) && y1)
        {
            transform.DORotate(endValue: new Vector3(x: 0, y: 0, z: 0), duration: 0);
            Invoke("y1t", 0.2f);

        }
        if (Input.GetMouseButtonUp(1) && y2)
        {
            transform.DORotate(endValue: new Vector3(x: 0, y: 0, z: 90), duration: 0);

            Invoke("y2t", 0.2f);
        }
        if (Input.GetMouseButtonUp(1) && y3)
        {
            transform.DORotate(endValue: new Vector3(x: 0, y: 0, z: 180), duration: 0);

            Invoke("y3t", 0.2f);
        }
        if (Input.GetMouseButtonUp(1) && y4)
        {
            transform.DORotate(endValue: new Vector3(x: 0, y: 0, z: -90), duration: 0);

            Invoke("y4t", 0.2f);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

    }
    void y1t()
    {
        y1 = false;
        y2 = true;
    }
    void y2t()
    {
        y1 = false;
        y2 = false;
        y3 = true;
    }
    void y3t()
    {
        y1 = false;
        y2 = false;
        y3 = false;
        y4 = true;
    }
    void y4t()
    {
        y1 = true;
        y2 = false;
        y3 = false;
        y4 = false;
    }
}
