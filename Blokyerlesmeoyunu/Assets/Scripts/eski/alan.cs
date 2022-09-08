using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alan : MonoBehaviour
{
    public GameObject anaobje;
    public Vector2 Baslangýcpos;
    void Start()
    {
        Baslangýcpos = transform.position;
    }

    
    void Update()
    {
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
    }


}
