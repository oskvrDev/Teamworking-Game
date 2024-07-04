using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE BELOW

    public bool isGreyCollided;
    public bool isGreenCollided;

    public PlayerStatisticsScript playerStatsScript;

    // Update is called once per frame
    void Update()
    {
        ChangeScene();
    }

    void ChangeScene()
    {
        
        if (isGreyCollided == true && isGreenCollided == true)
        {
            CurrentLevelScript.SaveALevelScore(playerStatsScript.ReturnStars(), SceneManager.GetActiveScene().buildIndex);
            StartCoroutine(SceneTimer()); //This allows the animations to play before the scene changes here.     
        }        
    }

    IEnumerator SceneTimer()
    {
        yield return new WaitForSeconds(1f);
        if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //The scene changes here.
        }
        else
        {

            SceneManager.LoadScene(0);
        }
    }
}
