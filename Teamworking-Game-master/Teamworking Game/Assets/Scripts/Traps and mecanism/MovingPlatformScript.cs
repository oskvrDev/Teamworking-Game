using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    //WRITTEN BY KATHERINE BELOW

    //public GameObject movingPlatform;
    public GameObject[] wayPoints;
    private int currentWayPointIndex = 0;

    public float speed = 2f;

    private Vector3 velo;
    private bool isMoving;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(wayPoints[currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointIndex++;
            if(currentWayPointIndex >= wayPoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);
    }

    private void OnCollisonEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Earth Girl" || collision.gameObject.tag == "Air Boy")
        {
            isMoving = true;
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnColliosionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Earth Girl" || collision.gameObject.tag == "Air Boy")
        {
            collision.collider.transform.SetParent(null);
        }
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            transform.position += (velo * Time.deltaTime);
        }
    }
}
