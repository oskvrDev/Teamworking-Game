using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2ExitScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE BELOW

    public ExitDoorScript exitDoorScript;
    public GameObject exitDoor; //The door in the scene
    public Animator anim; //The prefabs animator

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green Exit Door")
        {
            Debug.Log("exit");
            ExitAnimation();          
            exitDoorScript.GetComponent<ExitDoorScript>().isGreenCollided = true;         
        }
    }
    public void ExitAnimation() //Plays the animation
    {
        //anim = exitDoor.GetComponent<Animator>();
        anim.SetBool("isOpen", true);
    }
}
