using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 2f;
    public bool isGrounded2 = false;
    [SerializeField]
    public float jumpForce = 10f;
    [SerializeField]
    PlayerSounds playersounds;
    bool playing = false;


    void Start()
    {
        
    }

    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal1"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if ((Input.GetAxisRaw("Horizontal1") < 0 || Input.GetAxisRaw("Horizontal1") > 0) && isGrounded2 == true && playing == false)
            StartCoroutine(soundrepeat());
    }

    IEnumerator soundrepeat()
    {
        playing = true;
        playersounds.walksound.Play();
        yield return new WaitForSeconds(0.75f);
        playing = false;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Vertical1") && Input.GetAxisRaw("Vertical1") > 0 && isGrounded2 == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            playersounds.jumpSound();
       
        }
    }

    //WRITTEN BY KATHERINE BELOW
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EG Gem")
        {
            if (collision.gameObject.GetComponent<GreenGemScript>().isCollided == false)
            {
                collision.gameObject.GetComponent<GreenGemScript>().isCollided = true;
                Destroy(collision.gameObject); //destroys the specific gem for EG
                PlayerStatisticsScript.currentEarthGirlPoints += 1000;
            }
        }
    }
}