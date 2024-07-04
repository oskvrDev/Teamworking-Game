using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScript : MonoBehaviour

{
    public static GameObject instance;


    //public AudioSource music;

    //private float musicVol = 1f;
    

    //checks if it already exists, deletes the new object that has been created which is the music in this case.

    void Awake()
    {
        if (instance == null)
        {

            instance = this.gameObject;
           
              DontDestroyOnLoad(this.gameObject);
        }

        else if (instance != null)
        {
            Destroy(this.gameObject);
        }
     
    }


    // Update is called once per frame
    //void Update()
    //{
       // music.volume = musicVol;

    //}

    //public void updateVol( float vol)
    //{
        //musicVol = vol;
    //}
}



