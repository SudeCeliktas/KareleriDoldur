using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloktasıma : MonoBehaviour
{
    private float startPosx;
    private float startPorsy;
    private bool isBeingHeld = false;

    void Start()
    {

    }


    void Update()
    {
        if (isBeingHeld == true)
        {

            Vector3 Mousepos;
            Mousepos = Input.mousePosition;
            Mousepos = Camera.main.ScreenToWorldPoint(Mousepos);

            this.gameObject.transform.localPosition = new Vector3(Mousepos.x - startPosx, Mousepos.y - startPorsy, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 Mousepos;
            Mousepos = Input.mousePosition;
            Mousepos = Camera.main.ScreenToWorldPoint(Mousepos);
            startPosx = Mousepos.x - this.transform.localPosition.x;
            startPorsy = Mousepos.y - this.transform.localPosition.y;
            isBeingHeld = true;
        }

    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
