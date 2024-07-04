using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyColour Keycolour;

    public Key.KeyColour GetKeyColour(){
        return Keycolour;
        }

    public void OpenDoor()
    {
        gameObject.SetActive(false);
        Debug.Log("trigger");
    }
}

