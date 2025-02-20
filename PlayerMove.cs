using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    private float _hor;
    private float _ver;
    private SpriteRenderer _spriteRenderer;
    public Rigidbody2D rgb;
    public Animator animator;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _hor = Input.GetAxisRaw("Horizontal");
        _ver = Input.GetAxisRaw("Vertical");

        if(_hor == -1)
        {
            _spriteRenderer.flipX = true;
        }
        else if(_hor == 1)
        {
            _spriteRenderer.flipX = false;
        }
        
        rgb.velocity = new Vector2(_hor * speed, _ver * speed);

        bool isMoving = (_hor != 0 || _ver != 0);
        animator.SetBool("Run", isMoving);
        
    }
    
}







