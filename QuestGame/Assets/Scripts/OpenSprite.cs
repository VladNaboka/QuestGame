using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSprite : MonoBehaviour
{
    [SerializeField] GameObject bookOpenWardrobe;
    [SerializeField] Sprite objReplacement;
    public bool bookReplace;
    private void OnMouseDown()
    {
        if (bookReplace)
        {
            bookOpenWardrobe.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            bookOpenWardrobe.GetComponent<Image>().sprite = objReplacement;
        }
    }
    public void Back(GameObject gameObj)
    {
        gameObj.SetActive(false);
        Time.timeScale = 1f;
    }
    public void BackOnTime(GameObject gameObj)
    {
        gameObj.SetActive(false);
        Time.timeScale = 1f;
    }
}
