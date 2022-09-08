using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelupd : MonoBehaviour
{
    public SceneManager sceneman;
    public string levelname;
    [SerializeField] GameObject panel;
  
    void Start()
    {
        
    }


    void Update()
    {
     
    }
    public void levelupdate()
    {
        SceneManager.LoadScene(levelname);
    }

    public void exit()
    {
        Application.Quit();
    }
    public void retylevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LeaderButton()
    {
        panel.SetActive(true);
    }

    public void LeaderClosedButton()
    {
        panel.SetActive(false);
    }
}