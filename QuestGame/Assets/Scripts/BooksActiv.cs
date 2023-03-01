using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BooksActiv : MonoBehaviour
{
    private void OnMouseEnter()
    {
        GetComponent<Image>().enabled = true;
    }
    private void OnMouseExit()
    {
        GetComponent<Image>().enabled = false;
    }
}
