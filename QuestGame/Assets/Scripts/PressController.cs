using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressController : MonoBehaviour
{
    public ClampCamera clampCamera;
    [SerializeField] Vector2 playerPosition;
    [SerializeField] float leftClampPosition;
    [SerializeField] float rightClampPosition;
    GameObject player;
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnMouseDown()
    {
        if (SpritesActive.activTriggerObject == 1)
        {
            clampCamera.leftClamp = leftClampPosition;
            clampCamera.rightClamp = rightClampPosition;
            player.transform.position = playerPosition;
        }
    }
}
