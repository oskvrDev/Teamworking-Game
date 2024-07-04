using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatisticsScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE BELOW

    public static int currentEarthGirlPoints;
    public int startingEarthGirlPoints = 0;
    public static int currentAirBoyPoints;
    public int startingAirBoyPoints = 0;
    public int playerScores;


    [Header("here just add the points for 3 stars 2")]
   
    [SerializeField]
    int pointsFor2Star;
    [SerializeField]
    int pointsFor3Star;

    public Text EarthGirlPointsCounter;
    public Text AirBoyPointsCounter;

    // Start is called before the first frame update
    void Start()
    {
        currentEarthGirlPoints = startingEarthGirlPoints;
        currentAirBoyPoints = startingAirBoyPoints;
        playerScores = 0;
    }

    //CHANGE THE CURRENT EARTHGIRLPOINTS TO THE POINTS VARIABLE THAT STILL NEEDS TO BE CREATED
    public int ReturnStars()
    {
        AddScores();

        if(playerScores >= pointsFor3Star)
        {
            return 3;
        }
        else if(playerScores >= pointsFor2Star)
        {
            return 2;
        }
       
        return 1;
    }

    // Update is called once per frame
    void Update()
    {
        EarthGirlPointsCounter.text = currentEarthGirlPoints.ToString();
        AirBoyPointsCounter.text = currentAirBoyPoints.ToString();
    }

    public void AddScores()
    {
        playerScores = currentEarthGirlPoints + currentAirBoyPoints;
    }
}