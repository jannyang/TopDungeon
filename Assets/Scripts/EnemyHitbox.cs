using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    public int damage = 1;
    public float pushForce = 5;

    protected override void OnCollide(Collider2D coli)
    {
        if(coli.tag == "Fighter" && coli.name == "Player")
        {
            //Create a new damage object, before sending it o the player

            Damage dmg = new Damage()
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };

            coli.SendMessage("ReceiveDamage", dmg);
        }
    }
}
