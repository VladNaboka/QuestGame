using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    Vector2 clickPosition;
    bool activMove;

    public TextMeshProUGUI textDialog;
    public string textStr;

    Vector2 move;
    private void Start()
    {
        StartCoroutine(textPrint("Ух, поздновато я проснулся..."));
    }
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    clickPosition.y = gameObject.transform.position.y;
        //    activMove = true;
        //}
        //if (activMove)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, clickPosition, 5 * Time.deltaTime);
        //    if (transform.position.x == clickPosition.x)
        //        activMove = false;
        //}
        move.x = Input.GetAxis("Horizontal");
        transform.Translate(move * 5 * Time.deltaTime);
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wardrobe"))
        {
            StartCoroutine(textPrint("Так мой шкаф, может там что завалялось..."));
        }
        //if (collision.gameObject.name == "Table")
        //{
        //    StartCoroutine(textPrint("Опять я с Ромой бухал..."));
        //}
    }
    public IEnumerator textPrint(string textD)
    {
        for (int i = 1; i <= textD.Length; i++)
        {
            textDialog.text = textD.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
