using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded2 : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
            Player.GetComponent<Player2Controller>().isGrounded2 = true;


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
            Player.GetComponent<Player2Controller>().isGrounded2 = false;
    }
}
