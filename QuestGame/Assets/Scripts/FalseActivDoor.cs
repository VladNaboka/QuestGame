using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseActivDoor : MonoBehaviour
{
    [SerializeField] GameObject objDoor;

    private void OnEnable()
    {
        objDoor.SetActive(false);
    }
    private void OnDisable()
    {
        objDoor.SetActive(true);
    }
}
