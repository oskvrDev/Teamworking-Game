

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHold : MonoBehaviour
{
    [SerializeField]
    GameObject doorToOpen;
    [SerializeField]
    Sprite spritePressed;
    Sprite initialSprite;
    // Start is called before the first frame update
    void Start()
    {
        initialSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerStay2D(Collider2D collision)
    {
        doorToOpen.gameObject.SetActive(false);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spritePressed;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        doorToOpen.gameObject.SetActive(true);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = initialSprite;
    }
}
