using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Personaje
{
    
    private float magicPower;
   


    public Wizard()  //constructor por defecto
    {
        magicPower = 100;
        
    }



    public Wizard(string nameValue, float magicPowerValue, int healthValue, int armourValue) :
        base(nameValue, healthValue, armourValue)
    {
        
        magicPower = magicPowerValue;
      
    }


    public void AvadaKedabra()
    {
        Debug.Log("Te mato");
    }


    public void Attack()
    {
        base.Attack(magicPower);
    }

    
}

