using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tası : MonoBehaviour
{
    public static bool isDrag;
    public bool objevar = false;
    void OnMouseDrag()
    {
     
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new(mousePos.x, mousePos.y, transform.position.z);
        isDrag = true;
    }
    void OnMouseUp()
    {
        isDrag = false;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("block")) return;
        CheckCollision(other.gameObject, true , isDrag);
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("block")) return;
          CheckCollision(other.gameObject, false , !isDrag);
     

    }
    void CheckCollision(GameObject collisionObject, bool value ,bool checkState)
    {
        if (collisionObject.CompareTag("block")) return;

        if (!collisionObject.CompareTag("Tasi") || checkState) return;
        //transform.SetParent(other.transform);
        //transform.localPosition = Vector3.zero;
       
         Board.instance.pieces[int.Parse(collisionObject.name) - 1] = value;
         Board.instance.CheckFinish();
        
  
    }
}                   