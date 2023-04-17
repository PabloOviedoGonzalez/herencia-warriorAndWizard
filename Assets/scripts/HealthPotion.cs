using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : InventoryObject
{
    



    public HealthPotion() : base("HealthPotion", 5)
    {
        
    }

    public override void Use(Personaje pj)
    {
        pj.SetHealth(pj.GetHealth() + (int)valueToAdd);
        Debug.Log(name + pj.GetHealth());
    }





    //public void Use(Warrior w)
    //{
    //    Debug.Log(name + w.health + 5);
    //}

    //public void Use(Wizard wi)
    //{
    //    Debug.Log(name + wi.health + 5);
    //}
}
