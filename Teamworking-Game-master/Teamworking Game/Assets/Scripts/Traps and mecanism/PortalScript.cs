using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    [SerializeField]
    GameObject portalDestination;
    [SerializeField]
    GameObject player;
    
    public int playerTeleportPosition;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            StartCoroutine (Teleport());
        }
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds (0.5f);
        player.transform.position = new Vector2(portalDestination.transform.position.x + playerTeleportPosition, portalDestination.transform.position.y); 
    }                                                                                //^^^^^ Set this value in the inspector to 1 if you want the player to teleport on the right side or to -1 of the left side
}
