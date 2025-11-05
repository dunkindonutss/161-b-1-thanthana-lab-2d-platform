using UnityEngine;

public class Rock : Weapon
{
    public Rigidbody2D rb; //show this in Unity
    public Vector2 force; // use to throw Rock

    public override void Move()
    {
        //use physics in Unity (RigidBody2d) to add force to throw Rock
        rb.AddForce(force);
    }

    public override void OnHitWith(Character obj)
    {
        if (obj is Player)
        {
            obj.TakeDamage(this.Damage);
        }
    }

    void Start()
    {
        Damage = 40;
        force = new Vector2(GetShootDirection() * 90, 400);
        Move(); //add force to rock immediately once created
    }
}