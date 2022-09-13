using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController2D characterController;
    [SerializeField] float speed;

    float horizontalMove =0f;
    bool iJump = false;
    void Start()
    {
        characterController = GetComponent<CharacterController2D>();
    }
    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        if(Input.GetButtonDown("Jump")) iJump = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        characterController.Move(horizontalMove * Time.fixedDeltaTime,false, iJump);
        iJump = false;
    }
}
