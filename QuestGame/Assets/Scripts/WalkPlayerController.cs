using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Vector2 _move;
    SpriteRenderer _spriteRenderer;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        _move.x = Input.GetAxis("Horizontal");
        transform.Translate(_move * speed * Time.deltaTime);
        if (_move.x < 0)
        {
            animator.SetBool("Walk", true);
            _spriteRenderer.flipX = true;
        }
        else if (_move.x > 0)
        {
            animator.SetBool("Walk", true);
            _spriteRenderer.flipX = false;
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
