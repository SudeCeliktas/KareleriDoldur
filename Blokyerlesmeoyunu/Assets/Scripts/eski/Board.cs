using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public static Board instance;
    public bool[] pieces;
    void Awake()
    {
        instance = this;
      
    }
    public bool CheckFinish()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i]) return false;
        }
        FinishGame();
        return true;
    }
    public void FinishGame()
    {
        Debug.Log("Oyun Bitti");
    }
}
