using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje 
{
    private string name;
    protected int health, armour;
    InventoryObject[] arrayObjects;




   




    public Personaje()
    {
        health = armour = 0;
    }


    public Personaje(string nameValue, int healthValue, int armourValue)
    {
        name = nameValue;
        health = healthValue;
        armour = armourValue;

        arrayObjects = new InventoryObject[2];
        arrayObjects[0] = new HealthPotion();
        arrayObjects[1] = new ArmorPotion();


    }

    public void UseAllObjects()
    {
        for (int i = 0; i < arrayObjects.Length; i++)
        {
            arrayObjects[i].Use(this);
        }
    }



    protected void Attack(float value)
    {
        Debug.Log("Ataco con una fuerza de " + value);
    }






    public int GetHealth()
    {
        return health;
    }


    public void SetHealth(int value)
    {
        if(value >= 0)
        health = value;
    }

    public int GetArmour()
    {
        return armour;
    }


    public void SetArmour(int value)
    {
        if (value >= 0)
            armour = value;
    }






}
