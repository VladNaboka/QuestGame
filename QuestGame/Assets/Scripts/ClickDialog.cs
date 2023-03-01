using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDialog : MonoBehaviour
{
    public string textDialog = "...";
    [SerializeField] Dialog dialog;
    private void OnMouseDown()
    {
        if (SpritesActive.activTriggerObject == 2)
        {
            dialog.ClearDialog();
            StartCoroutine(dialog.textPrint(textDialog));
        }
    }
}
