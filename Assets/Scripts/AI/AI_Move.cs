using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveCommand",menuName ="Create movement command")]
public class AI_Move : AICommand
{
    [SerializeField] float moveSpeed =6f;
    [SerializeField] float fallMultiplier = 3f;
    [SerializeField] float movementTime;
    [SerializeField] LayerMask groundMask;
    Transform groundCheck;
    const float k_GroundedRadius = .2f;
    float timer;
    bool isGrounded;
    public override void AIUpdate(float deltaTime)
    {
        rb.velocity = moveSpeed * transform.right + new Vector3(0,rb.velocity.y);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, k_GroundedRadius, groundMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != transform.gameObject)
            {
                isGrounded = true;
            }
        }

        if (!isGrounded)
        {
            rb.velocity += fallMultiplier * Vector2.up * Physics2D.gravity.y * deltaTime;
        }
        timer -=deltaTime;
        if (timer <= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            OnPatternEnd?.Invoke();
        }
    }

    public override void Start()
    {
        groundCheck = transform.GetChild(2);
        rb.isKinematic= false;
        timer = movementTime;
    }
}

