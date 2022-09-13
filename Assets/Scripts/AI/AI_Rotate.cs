using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "JumpCommand", menuName = "Create rotate command")]
public class AI_Rotate : AICommand
{

    public override void AIUpdate(float deltaTime)
    {
        OnPatternEnd?.Invoke();
    }

    public override void Start()
    {
        rb.isKinematic = false;
        if (transform.rotation.y == 0) transform.rotation = Quaternion.Euler(0, 180, 0);
        else transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
