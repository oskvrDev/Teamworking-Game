using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    //script made by miguel boavida
    //the moving of the enemy got inspiration from the moving platform script
    //this will change the player speed
    [SerializeField]
    float speed = 2f;
    //this will keep track of wich wapoint the enemy is    
    int currentWayPoint=0;

    [SerializeField]
    Transform[] wayPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the player is close to the waypoint if it is go to the next one
        if (Vector2.Distance(wayPoints[currentWayPoint].transform.position, transform.position) < .1f)
        {
            currentWayPoint++;
            if(currentWayPoint >= wayPoints.Length)
            {
                currentWayPoint = 0;
            }
        }
        //call the function that will move the ai
        MoveAi();
        //flip the enemy
        Flip();
    }

    void MoveAi()
    {
        //move the enemy to the waypoint
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * speed);
    }

    void Flip()
    {
        //this if else will rotate the enemy
        if(wayPoints[currentWayPoint].transform.position.x>this.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}
