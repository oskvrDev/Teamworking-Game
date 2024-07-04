 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiMenuHandlerScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE

    public GameObject uiMenu;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        HelloMenu();
    }

    void HelloMenu()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0f;
            uiMenu.SetActive(true);
        }
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        uiMenu.SetActive(false);
    }

    public void SceneRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
