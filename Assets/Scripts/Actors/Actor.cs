using UnityEngine;

public abstract class Actor : MonoBehaviour 
    //Abstract : Prevents any accidental attachment to game objects
    // main script that most scripts pulls from is often declared as abstract
{
    [Header("Base Attributes")]
    [SerializeField] protected float maxHp = 100f;

    protected float currentHp;

    [SerializeField] protected float baseDmg = 15f;
    [SerializeField] protected float mSpeed = 5f;

    protected virtual void Awake()
    {
        currentHp = maxHp;
    }

    public abstract void PerformAttack();
    
    public virtual void TakeDamage(float damageAmount)
    {
        currentHp -= damageAmount;
        Debug.Log($"{gameObject.name} took {damageAmount} like a mf");
        
    }

    public virtual void Die()
    {
        Debug.Log($"this just in, {gameObject.name} has died!");
        Destroy(gameObject);
    }


    // Virtual (default room to personalize) | Abstract (Mandatory blank canvas) | Override ( base.Methode() )
}
