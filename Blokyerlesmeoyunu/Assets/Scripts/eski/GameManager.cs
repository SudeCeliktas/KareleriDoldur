using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Blok1, blok2, blok3, blok4;
    public int Yer1, Yer2;
    public Transform Yer1t, yer2t;



    void Start()
    {
       Yer1 = Random.Range(1, 5);
        Yer2 = Random.Range(1, 5);
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Yer1 = Random.Range(1, 5);
            Yer2 = Random.Range(1, 5);
        }
        if(Yer1 == Yer2)
        {
            Yer1 = Random.Range(1, 5);
            Yer2 = Random.Range(1, 5);
        }
    }
}
