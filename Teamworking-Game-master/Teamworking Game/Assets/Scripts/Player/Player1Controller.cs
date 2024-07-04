using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 2f;
    public bool isGrounded = false;
    [SerializeField]
    public float jumpforce = 10f;
    [SerializeField]
    PlayerSounds playersounds;
    bool playing = false;

   

    void Start()
    {
     
    }

    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if ((Input.GetAxisRaw("Horizontal") < 0 || Input.GetAxisRaw("Horizontal") > 0) && isGrounded == true && playing == false)
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
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0 && isGrounded == true )
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            playersounds.jumpSound();
        }


    }

    //WRITTEN BY KATHERINE BELOW
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "AB Gem")
        {
            if (collision.gameObject.GetComponent<GreyGemScript>().isCollided == false)
            {
                collision.gameObject.GetComponent<GreyGemScript>().isCollided = true;
                Destroy(collision.gameObject); //destroys the specific gem for AB
                PlayerStatisticsScript.currentAirBoyPoints += 1000;
            }
        }
    }
}