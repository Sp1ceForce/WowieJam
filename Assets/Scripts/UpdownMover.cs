using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdownMover : MonoBehaviour
{
    [SerializeField] float maximumAmplitude = 0.25f;
    [SerializeField] float floatSpeed = 0.5f;
    Vector2 lowestPos;
    Rigidbody2D rb;

    void Start()
    {
        lowestPos = new Vector2(transform.position.x, transform.position.y - maximumAmplitude);
        rb = GetComponent<Rigidbody2D>();
        rb.DOMoveY(lowestPos.y, floatSpeed).SetLoops(-1,LoopType.Yoyo);
    }
}
