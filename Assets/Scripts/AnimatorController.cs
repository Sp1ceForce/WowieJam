using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    CharacterController2D characterController;
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        characterController = GetComponentInParent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("HorizontalSpeed",Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        animator.SetBool("isJumping", !characterController.IsGrounded());
    }

}
