using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private List<Key.KeyColour> KeyColours;

    [SerializeField] private Key.KeyColour Keycolour;

    public Key.KeyColour GetKeyColour()
    {
        return Keycolour;
    }

    //list of keys

    private void Awake()
    {
        KeyColours = new List<Key.KeyColour>();
    }

    //add a key to the player

    public void AddKey(Key.KeyColour KeyColour)
    {
        Debug.Log("Added Key: " + KeyColour);
        KeyColours.Add(KeyColour);
    }

    //remove a key from the player(used on door interaction)
    public void RemoveKey(Key.KeyColour KeyColour)
    {
        KeyColours.Remove(KeyColour);
    }

    //checks which key the player is holding from the list

    public bool HoldingKey(Key.KeyColour keyColour)
    {
        return KeyColours.Contains(keyColour);
    }

    //if the player collides with the key, then they grab the key into their "inventory"

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Key key = collision.GetComponent<Key>();
        //check if the key is null and theyr colours are the same
        if (key != null && GetKeyColour() == key.GetKeyColour())
        {
            AddKey(key.GetKeyColour());
            Destroy(key.gameObject);
        }

        //if the player collides with the door, it tests if the door is opened with a certain key and if the player has it

        KeyDoor keyDoor = collision.GetComponent<KeyDoor>();
        if (keyDoor != null)
        {
            if (HoldingKey(keyDoor.GetKeyColour()))
            {
                RemoveKey(keyDoor.GetKeyColour());
                keyDoor.OpenDoor();
                Debug.Log("removed key");
            }

        }
    }
}