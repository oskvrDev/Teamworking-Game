using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosingScreen : MonoBehaviour
{
   public GameObject losingScreenUI;

   public void Retry()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Menu() 
    {
       SceneManager.LoadScene("Menu");
    }
}
