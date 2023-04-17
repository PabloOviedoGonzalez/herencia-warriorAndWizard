using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPotion : InventoryObject
{
    




    public ArmorPotion() :base("ArmorPotion", 100)
    {
        
    }

    public override void Use(Personaje pj)
    {
        pj.SetArmour(pj.GetArmour() + (int)valueToAdd);
        Debug.Log(name + pj.GetArmour());
    }






    //public void Use(Warrior w)
    //{
    //    Debug.Log(name + w.armour + 5);
    //}

    //public void Use(Wizard wi)
    //{
    //    Debug.Log(name + wi.armour + 5);
    //}

}
