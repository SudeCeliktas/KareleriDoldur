using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasıma : MonoBehaviour
{
 
    public GameObject tası;
    
    Camera Camera;
    public bool deg;
    void Start()
    {
      
       Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
       
        
     
    }
    private void OnMouseDrag()
    {
      
            Vector3 pozisyon = Camera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
        
     //   tası.GetComponent<Tası>().yerlesme = false;
       
    }

    // Update is called once per frame
    void Update()
    {

     
    }

    public void backstage()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tasi")
        {
            deg = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tasi")
        {
            deg = false;
        }
        if(collision.gameObject.tag == "Block" )
        {
       
           // tası.GetComponent<Tası>().yerlesme = false;
        }
    }
}
