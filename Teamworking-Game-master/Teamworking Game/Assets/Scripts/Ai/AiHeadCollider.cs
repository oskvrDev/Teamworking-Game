using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiHeadCollider : MonoBehaviour
{  
    [SerializeField]
    //this will get the player that can kill this enemy
    GameObject playerToKillEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if this gameobject collided with the player that can kill him, destroy this object
        if (collision.gameObject==playerToKillEnemy)
        {
           Destroy(transform.parent.gameObject);
        }
    }
}
