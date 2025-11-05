using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
   public int Damage;
   public IShootable Shooter;
   
   public abstract void Move();
   public abstract void OnHitWith(Character character);
   
   public void InitWeapon(int newDamage, IShootable newShooter)
   { 
      Damage = newDamage;
      Shooter = newShooter;
   }

   public int GetShootDirection()
   {
      float value = Shooter.ShootPoint.position.x - Shooter.ShootPoint.parent.position.x;
      if (value > 0)
      {
         return 1; //right
      }
      else
      {
         return -1; //left
      }
   }
   
   private void OnTriggerEnter2D(Collider2D other)
   {
      Character character = other.GetComponent<Character>();
      if (character != null)
      {
         OnHitWith(other.GetComponent<Character>());
         Destroy(this.gameObject, 5f);
      }
   }
}
