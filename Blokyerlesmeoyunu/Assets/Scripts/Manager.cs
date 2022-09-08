using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject[] parca;

    void Start()
    {
        parca = GameObject.FindGameObjectsWithTag("Parca");
        StartCoroutine(ParcaKullanilabilir());
    }

    IEnumerator ParcaKullanilabilir()
    {
        yield return new WaitForSeconds(1.0f);
        if (parca != null)
        {
            foreach (GameObject gp in parca)
            {
                gp.GetComponent<Animator>().enabled = false;
            }
        }
    }
}