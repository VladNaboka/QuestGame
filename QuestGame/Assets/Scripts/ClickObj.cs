using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObj : MonoBehaviour
{
    public GameObject player;
    public GameObject clicker;
    public string printMessage;
    private void Start()
    {
        player = GameObject.Find("Player");
        clicker = GameObject.Find("ClickObject");
        clicker.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.position == player.transform.position)
        {
            clicker.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.transform.position == player.transform.position)
        {
            clicker.SetActive(false);
        }
    }
    private void OnMouseEnter()
    {
        Debug.Log("Dsd");
        clicker.transform.localScale = new Vector2(0.8f, 0.8f);
    }
    private void OnMouseExit()
    {
        clicker.transform.localScale = new Vector2(0.7f, 0.7f);
    }
    private void OnMouseDown()
    {
        player.GetComponent<PlayerController>().StartCoroutine(player.GetComponent<PlayerController>().textPrint(printMessage));
    }
}
