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
    
    [SerializeField] private HealthBar healthBar;
    
    //initialize character
    public void Initialize(int startHealth)
    {
        Health = startHealth;
        if (healthBar != null)
            healthBar.SetMaxHealth(startHealth);
        Debug.Log($"{this.name} initial Health : {startHealth}");
    }
    //Behavior
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took {damage} DMG, HP LEFT : {Health}");

        if (healthBar != null)
            healthBar.UpdateHealthBar();
    }
 
    public bool IsDead() 
    {
        if (Health <= 0)
        {
            Debug.Log($"{this.name} is dead");
            Destroy(gameObject);
            return true;
        }
        else
        {
            return false;
        }
    }
}
