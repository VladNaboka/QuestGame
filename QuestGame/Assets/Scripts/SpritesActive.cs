using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesActive : MonoBehaviour
{
    public static float activTriggerObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && gameObject.CompareTag("Door"))
        {
            //GetComponent<SpriteRenderer>().enabled = true;
            activTriggerObject = 1;
        }
        if (collision.CompareTag("Player") && gameObject.CompareTag("Wardrobe"))
        {
            //GetComponent<SpriteRenderer>().enabled = true;
            activTriggerObject = 2;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            activTriggerObject = 0;
        }
    }
}
