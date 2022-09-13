using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] float doorSpeed = 0.4f;
    Vector2 closedPos;
    private void Start()
    {
        closedPos = transform.position;
    }
    public void CloseDoor()
    {
        transform.DOMove(closedPos, doorSpeed);
    }
    public void OpenDoor()
    {
        transform.DOLocalMove(Vector2.zero, doorSpeed);
    }
}
