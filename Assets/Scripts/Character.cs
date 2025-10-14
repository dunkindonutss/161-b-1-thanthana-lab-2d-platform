using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //attributes
    private int health;
    public int Health 
    { 
        get => health; 
        set => health = (value < 0) ? 0 : value; 
    }
    protected Animator anim;
    protected Rigidbody2D rb;
    //initialize character
    public void Initialize(int startHealth)
    {
        Health = startHealth;
        Debug.Log($"{this.name} initial Health : {startHealth}");
    }
    //Behavior
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took {damage} DMG, HP LEFT : {Health}");
    }
 
    public bool IsDead() 
    {
        if (Health <= 0)
        {
            Debug.Log($"{this.name} is dead");
            return true;
        }
        else
        {
            return false;
        }
    }
}
