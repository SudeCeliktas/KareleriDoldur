using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotmanager : MonoBehaviour
{
    public static Board instance;
    public GameObject skormanager;
  
    public bool[] pieces;
    void Start()
    {
        
    }

  
    void Update()
    {

       
    }
    public bool CheckFinish()
    {
        //skormanager.GetComponent<skormanager>().bitti();
        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i]) return false;
        }
        FinishGame();
        return true;
    }
    public void FinishGame()
    {
        Debug.Log("bitti"); 
        skormanager.GetComponent<skormanager>().bitti();
     //   skormanager.GetComponent<skormanager>().bittiz = true;
        
    }
}
