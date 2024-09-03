using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{   
    public GameObject GameOverpanel;
    // Update is called once per frame
    void Update()
    {
      if (GameObject.FindGameObjectWithTag("player") == null)  
      {
           GameOverpanel.SetActive(true);
      }
    }

     public void Restart() 
     {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}
