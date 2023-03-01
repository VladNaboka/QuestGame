using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    [SerializeField] GameObject player;
    bool activTransition = true;
    [SerializeField] Vector2 directionCamera;
    Vector2 posCamera;
    private void Start()
    {
        posCamera = Camera.main.transform.position;
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.position == player.transform.position)
        {
            activTransition = !activTransition;
            //StartCoroutine(CameraMove());
        }
    }
    IEnumerator CameraMove()
    {
        yield return new WaitForSeconds(0.5f);
        //Camera.main.transform.position = new Vector2(16f, 0.29f);
        Camera.main.transform.position = Vector2.Lerp(Camera.main.transform.position, new Vector2(16f, 0.29f), 2 * Time.deltaTime);
    }
    private void Update()
    {
        if (!activTransition)
            Camera.main.transform.position = Vector2.Lerp(Camera.main.transform.position, new Vector2(directionCamera.x, directionCamera.y), 2 * Time.deltaTime);
        else if (activTransition)
            Camera.main.transform.position = Vector2.Lerp(Camera.main.transform.position, posCamera, 2 * Time.deltaTime);
    }
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.transform.position == player.transform.position)
    //    {
    //        Debug.Log("Trigger");
    //        Camera.main.transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + 19f, transform.position.y), 5 * Time.deltaTime);
    //    }
    //}
}
