using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE BELOW

    public GameObject earthGirl;
    public GameObject losingScreenUI;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Miguel changed the if
        if (collision.gameObject == earthGirl.gameObject)
        {
            Destroy(earthGirl);
            losingScreenUI.SetActive(true);
            //and Respawn at respawn point:)
        }
      
    }
}
