using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDialog;
    public string textStr;
    private void Start()
    {
        StartCoroutine(textPrint("Так, надо понять, что тут происходит..."));
    }
    public IEnumerator textPrint(string textD)
    {
        for (int i = 1; i <= textD.Length; i++)
        {
            textDialog.text = textD.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
            if (i == textD.Length)
            {
                yield return new WaitForSeconds(3f);
                textDialog.text = "...";
            }
        }

    }
    public void ClearDialog()
    {
        textDialog.text = "";
    }
}
