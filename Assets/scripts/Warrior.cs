using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Personaje
{
    private float attackPower;
   


    public Warrior()  //constructor por defecto
    {
        attackPower = 10;
        
    }



    public Warrior(string nameValue, float attackPowerValue, int healthValue, int armourValue) : base(nameValue, healthValue, armourValue)
    {

        attackPower = attackPowerValue;
        
    }


    public void Attack()
    {
        base.Attack(attackPower);
    }

   
    
}
