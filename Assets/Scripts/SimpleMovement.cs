using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;
    private float inputForce;
    private Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Vector2.zero;
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        inputForce = Input.GetAxisRaw("Horizontal");
        if (inputForce != 0)
            spriteRenderer.flipX = inputForce < 0;

        animator.SetBool("run", inputForce != 0);
        speed.x = inputForce * 5;
        rigidBody.velocity =  speed;
    }
}
