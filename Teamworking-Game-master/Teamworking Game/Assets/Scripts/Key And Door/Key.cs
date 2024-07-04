using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    [SerializeField]
    private KeyColour Keycolour;

    public enum KeyColour
    {
        Red,
        Blue,
        Grey,
        Green

    }
    public KeyColour GetKeyColour()
    {
        return Keycolour;
    }
}
