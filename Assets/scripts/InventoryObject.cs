using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject 
{
    public string name;
    public float valueToAdd;





    public InventoryObject(string nameValue, float valueToAddThis)
    {
        name = nameValue;
        valueToAdd = valueToAddThis;
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
