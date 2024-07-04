using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentLevelScript : MonoBehaviour
{
    [SerializeField]
    //this will store every levels gameobjects
    GameObject[] LevelsGameObject;
    //this will store the current levels passed
    int currentLevelsPassed;
    //this will store the current stars
    List<int> levelStars = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        //DeleteEveryProgress();
        //SaveALevelScorefirst(3, 1);
       
        LoadLevelScore();
    }

    public void DeleteEveryProgress()
    {
        //delete every progress
        PlayerPrefs.DeleteAll();
        //do a foreach to hide every level i do this because the levels are already loaded so they will still be showed, and only hiden when the game is reloaded, so i do this foreach to hide every level
        foreach (GameObject n in LevelsGameObject)
        {
            n.SetActive(false);
        }
        //activate the level 1 and hide its stars
        LevelsGameObject[0].SetActive(true);
        LevelsGameObject[0].transform.GetChild(1).gameObject.SetActive(false);
        LevelsGameObject[0].transform.GetChild(2).gameObject.SetActive(false);
        LevelsGameObject[0].transform.GetChild(3).gameObject.SetActive(false);
    }

    //this function will save the score
    public static void SaveALevelScore(int stars, int levelNumber)
    {
        //if we are in a bigger level then already passed just say that our current level is the same as the current level played, and save it
        if (levelNumber > PlayerPrefs.GetInt("CurrentLevels"))
        {
            //currentLevelsPassed = levelNumber;
            //PlayerPrefs.SetInt("CurrentLevels", currentLevelsPassed);
            PlayerPrefs.SetInt("CurrentLevels", levelNumber);
            PlayerPrefs.SetInt("Stars" + levelNumber, stars);
        }
        else
        {
            //this will check if the level already has more stars then the stars done by the player
            if(PlayerPrefs.GetInt("Stars" + levelNumber)<stars)
            {
                PlayerPrefs.SetInt("Stars" + levelNumber, stars);
            }
        }
        

        PlayerPrefs.Save();
    }


    public static void SaveALevelScorefirst(int stars, int levelNumber)
    {
        /*//if we are in a bigger level then already passed just say that our current level is the same as the current level played, and save it
        if (levelNumber > PlayerPrefs.GetInt("CurrentLevels"))
        {
            //currentLevelsPassed = levelNumber;
            //PlayerPrefs.SetInt("CurrentLevels", currentLevelsPassed);
         
        }
        else
        {
            //this will check if the level already has more stars then the stars done by the player
            if (PlayerPrefs.GetInt("Stars" + levelNumber) < stars)
            {
                PlayerPrefs.SetInt("Stars" + levelNumber, stars);
            }
        }
        */

        PlayerPrefs.SetInt("CurrentLevels", levelNumber);
        PlayerPrefs.SetInt("Stars" + levelNumber, stars);
        PlayerPrefs.Save();
    }


    //this will load all scores
    void LoadLevelScore()
    {
        //this will get how many levels we have
        currentLevelsPassed = PlayerPrefs.GetInt("CurrentLevels");

        //Make add stars
        for (int i = 1; i <= currentLevelsPassed; i++)
        {
            levelStars.Add(PlayerPrefs.GetInt("Stars" + i));
        }
        //call function to show the levels
        ShowLevels();
    }

    void ShowLevels()
    {
        //do a for trought all of the current levels passed, i have +1, to show one itrem more, the next level.
        for (int i = 0; i < currentLevelsPassed+1; i++)
        {
            //i do a try because it can break on the last item
           
           
                //activate the level game object
                LevelsGameObject[i].gameObject.SetActive(true);
                //activate the text
                LevelsGameObject[i].transform.GetChild(0).gameObject.SetActive(true);

                if(levelStars.Count>=(i+1))
                {
                    
                    //do a for to activate its stars
                    for (int x = 0; x < levelStars[i]; x++)
                    {
                        LevelsGameObject[i].transform.GetChild(x + 1).gameObject.SetActive(true);
                    }

                }
                
                        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
