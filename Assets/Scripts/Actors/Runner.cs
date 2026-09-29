using UnityEngine;

public class Runner : Actor
{
    protected override void Awake()
    {
        base.Awake();
        maxHp = 10f;
        currentHp = maxHp;
        mSpeed = 50f;
    }
    public override void PerformAttack()
    {
        Debug.Log($"{gameObject}is fast as fucc boi!");
    }
}
