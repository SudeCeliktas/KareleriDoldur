using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    tutma tut;
    tutma tutma;
    public int dolu;
    public GameObject slotmanager;

    private void Start()
    {

        tutma = FindObjectOfType<tutma>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot" & dolu == 0)
        {
            collision.gameObject.transform.position = this.transform.position;
            collision.gameObject.GetComponent<Kare>().girdi = 1;
            //kare parçalarý bir slota girmiþ ise 1 girmemiþ ise 0
            slotmanager.GetComponent<slotmanager>().pieces[int.Parse(this.name) - 1] = true;

            slotmanager.GetComponent<slotmanager>().CheckFinish();
            //dolu 1 ise bu slot dolu dolu 0 ise bu slot boþdur
        }
        if (collision.gameObject.tag == "Slot")
        {

            dolu += 1;
            //dolu 1 ise bu slot dolu dolu 0 ise bu slot boþdur
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slot" & dolu >= 1)
        {
            dolu -= 1;
            collision.gameObject.GetComponent<Kare>().girdi = 0;
            slotmanager.GetComponent<slotmanager>().pieces[int.Parse(this.name) - 1] = false;
        }
    }
}
