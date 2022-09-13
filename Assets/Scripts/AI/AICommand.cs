using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class AICommand : ScriptableObject
{
    public UnityEvent OnPatternEnter;
    public string Name;
    public UnityEvent OnPatternEnd;
    protected Rigidbody2D rb;
    protected Transform transform;
    abstract public void Start();
    virtual public void Init(Rigidbody2D rb, Transform transform)
    {
        this.rb = rb;
        this.transform = transform;
    }
    abstract public void AIUpdate(float deltaTime);
}
