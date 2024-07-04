using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverABScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE BELOW

    public GameObject exitWall;
    public GameObject lava;
    public GameObject notLavaFloor;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Air Boy")
        {
            Debug.Log("Lever pressed");
            Destroy(exitWall);
            lava.SetActive(false);
            notLavaFloor.SetActive(true);
        }
    }
}
