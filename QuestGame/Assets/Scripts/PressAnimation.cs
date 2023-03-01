using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnimation : MonoBehaviour
{
    bool animActiv;
    public Animator anim;
    [SerializeField] Dialog dialog;
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        animActiv = true;
    //    }
    //}
    private void OnMouseDown()
    {
        animActiv = !animActiv;
        StartCoroutine(dialog.textPrint("Свет тут плохо работает"));
    }
    private void Update()
    {
        if (animActiv)
        {
            anim.SetBool("LightBreak", true);
        }
        else
        {
            anim.SetBool("LightBreak", false);
        }
    }
}
