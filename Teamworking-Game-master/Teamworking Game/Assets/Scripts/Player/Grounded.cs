using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
            Player.GetComponent<Player1Controller>().isGrounded = true;


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Floor")
            Player.GetComponent<Player1Controller>().isGrounded = false;
    }
}
