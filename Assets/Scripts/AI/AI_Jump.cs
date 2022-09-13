using UnityEngine;

[CreateAssetMenu(fileName = "JumpCommand", menuName = "Create jump command")]
public class AI_Jump : AICommand
{
    [SerializeField] float jumpForce = 6f;
    float timer;

    public override void AIUpdate(float deltaTime)
    {
        if (rb.velocity.y == 0)
        {
            OnPatternEnd?.Invoke();
        }
    }

    public override void Start()
    {
        transform.GetComponentInChildren<AudioSource>().Play();
        rb.isKinematic = false;
        rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
    }
}