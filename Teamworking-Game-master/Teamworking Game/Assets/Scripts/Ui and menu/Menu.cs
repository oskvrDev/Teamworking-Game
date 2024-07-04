using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    [SerializeField]
    GameObject LoadLevel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Play ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);       
    }

    public void LoadLevelOne ()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevelTwo ()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(3);
    }


    public void LoadLevelFour()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLevelFive()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadLevelSix()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadLevelSeven()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadLevelEight()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadLevelNine()
    {
        SceneManager.LoadScene(9);
    }

    //public void LoadLevelTen()
    //{
    //SceneManager.LoadScene(10);
    //}



}
