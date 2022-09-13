using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class PressurePlateScript : MonoBehaviour
{
    [SerializeField] DoorScript door;
    [SerializeField] Transform RedPart;
    [SerializeField] float pressTime = 0.5f;
    [SerializeField] float pressedY = -0.1f;
    [SerializeField] float freeY = 0.2f;
    [SerializeField] Color pressedColor;
    [SerializeField] Color freeColor;
    public UnityEvent OnPress;
    public UnityEvent OnLeave;
    [SerializeField] bool forewerOpen = false;
    bool isPressed = false;
    GameObject objectOnPlate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPressed) return;
        if (isPressed != false) return;
        OnPress?.Invoke();
        door.OpenDoor();
        RedPart.DOLocalMoveY(pressedY, pressTime);
        RedPart.GetComponent<SpriteRenderer>().color = pressedColor;
        objectOnPlate = collision.gameObject;
        isPressed = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (forewerOpen) return;
        if (objectOnPlate != collision.gameObject) return;
        OnLeave?.Invoke();
        RedPart.DOLocalMoveY(freeY, pressTime);
        RedPart.GetComponent<SpriteRenderer>().color = freeColor;
        door.CloseDoor();
        isPressed = false;
    }
}
