using UnityEngine;

[CreateAssetMenu(fileName = "StopCommand", menuName = "Create stop command")]
public class AI_Stop : AICommand
{
    public override void AIUpdate(float deltaTime)
    {
        rb.velocity = Vector3.zero;
    }

    public override void Start()
    {

        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.layer = 8;
        rb.isKinematic = true;
    }
}
