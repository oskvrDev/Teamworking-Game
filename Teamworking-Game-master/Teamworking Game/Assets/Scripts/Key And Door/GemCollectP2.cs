using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollectP2 : MonoBehaviour
{ //copied from katherine
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EG Gem"))
        {
            Destroy(collision.gameObject);
            ScoreSystem.Score = ScoreSystem.Score + 10;
        }
    }
}
