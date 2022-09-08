using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skormanager : MonoBehaviour
{
    public TMP_Text scoretext,Timetext,starttext;
    public GameObject slotmanager, endtext, timendtext, endpanel, timetext1,starttext1;
    public int skor;
    public int sayý1;
    public float zaman;
    public float zamanstart=4;
    public bool bittiz = false, start1 = false, level1;
    public bool zamanlý,zamantextstart1;
    void Start()
    {

        if (level1)
        {
         Invoke("start12",4);
        }
        else
        {
            starttext1.SetActive(false);
            Invoke("start12", 0);
        }
        
      
    }


    void Update()
    {
       
        Timetext.text = "" + (int)zaman;
        if (start1 == false)
        {
       zamanstart -= Time.deltaTime;
      starttext.text = "" + (int)zamanstart;
        }

        if (zamantextstart1)
        {
      if(bittiz== false)
        {
          
        zaman -= Time.deltaTime;
         
        }
      if(bittiz == false)
        {
       if (zaman < 0|| zaman == 0)
        {
                Timetext.text = "0";
            Invoke("bitti",0);
            bittiz = true;
            
            Debug.Log("bitti");
                    endtext.SetActive(false);
        }
            }
            else
            {
                timetext1.SetActive(false);
            }
        }
         
  
        
        scoretext.text = skor.ToString();


 
    }
    public void bitti()
    {
      //  if (bittiz == true)
        //{
            for (int sayý = 0; sayý < sayý1; sayý++)
            {

                if (slotmanager.GetComponent<slotmanager>().pieces[sayý] == true)
                {

                    skor += 1;

                }
            }
           
     //   }
  
        
            skor = skor * 100 / sayý1;
        

        endpanel.SetActive(true);
        if (skor == 100&&bittiz ==false)
        {
            endtext.SetActive(true);
        }
        else
        {
            timendtext.SetActive(true);
        }
        timetext1.SetActive(false);

    }
    void start12()
        {
            starttext1.SetActive(false);
            start1 = true;
            if (zamanlý)
            {

                zamantextstart1 = true;
                timetext1.SetActive(true);
            }
        }
        }

