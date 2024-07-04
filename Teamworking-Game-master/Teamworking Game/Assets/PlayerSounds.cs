using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour

{


    public bool playing = false;


    public AudioSource jumpsound;
    public AudioSource walksound;
    // Start is called before the first frame update

    public void jumpSound ()
    
    {

        jumpsound.Play();
    
     }


    // Update is called once per frame
    void Update()
    {

    }
}
