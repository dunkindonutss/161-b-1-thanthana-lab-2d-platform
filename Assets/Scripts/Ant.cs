using System;
using UnityEngine;

public class Ant : Enemy
{
    public Vector2 velocity;
    public Transform[] movePoints;
    private Rigidbody2D rb;
     void Start()
     {
     base.Initialize(20);
     DamageHit = 20;
     //set speed and direction of movement
     velocity = new Vector2(-1.0f, 0.0f); //start with moving left
     rb = GetComponent<Rigidbody2D>();
     }
     
     public override void Behavior()
     {
     //move from current position
     rb.MovePosition( rb.position + velocity * Time.fixedDeltaTime );
     //move left และเกินขอบซ้าย
     if ( velocity.x < 0 && rb.position.x <= movePoints[0].position.x )
     {
     Flip();
     }
     //move right และเกินขอบขวา
     if ( velocity.x > 0 && rb.position.x >= movePoints[1].position.x )
     {
     Flip();
     }
     }
     //flip ant to the opposite direction
     public void Flip()
     {
     velocity.x *= -1; //change direction of movement
     //Flip the image
     Vector3 theScale = transform.localScale;
     theScale.x *= -1;
     transform.localScale = theScale;
     }
     private void FixedUpdate()
     {
     Behavior();
     }

     private void Update()
     {
         IsDead();
     }
}
