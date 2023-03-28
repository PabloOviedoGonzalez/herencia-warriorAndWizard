using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje 
{
    private string name;
    protected int health, armour;


    public Personaje()
    {
        health = armour = 0;
    }


    public Personaje(string nameValue, int healthValue, int armourValue)
    {
        name = nameValue;
        health = healthValue;
        armour = armourValue;



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
        health = value;
    }
}
