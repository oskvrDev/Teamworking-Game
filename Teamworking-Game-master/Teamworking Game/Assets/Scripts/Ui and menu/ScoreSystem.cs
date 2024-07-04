using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int Score;
    public Text scoreText;

    void Update()
    {
        scoreText.text = Score.ToString();
    }
}
