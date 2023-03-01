using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSprite : MonoBehaviour
{
    [SerializeField] GameObject bookExelent;
    [SerializeField] Sprite objReplacement;
    public bool bookReplace;
    private void OnMouseDown()
    {
        if (bookReplace)
        {
            bookExelent.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            bookExelent.GetComponent<Image>().sprite = objReplacement;
        }
    }
    public void Back(GameObject gameObj)
    {
        gameObj.SetActive(false);
    }
    public void BackOnTime(GameObject gameObj)
    {
        gameObj.SetActive(false);
        Time.timeScale = 1f;
    }
}
