using UnityEngine;

public class Grunt : Actor
{
    protected override void Awake()
    {
        base.Awake();
        maxHp = 40f;
        currentHp = maxHp;
        mSpeed = 4;
    }

    public override void PerformAttack()
    {
        Debug.Log($"{gameObject.name} declares, Some Bullshit!");
    }


}
