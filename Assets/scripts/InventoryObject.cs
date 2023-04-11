using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : Personaje
{

    //profe, para q me deje acceder a "health" he puesto q el inventory herede de personaje para tener acceso 
    //a todo sin bajarle el nivel de proteccion para no hacerlo publico. No se si vale, si no seria hacer el 
    //"health" publico pero eso es como chungo.
    public string name;
    public float valueToAdd;





    public InventoryObject(string nameValue, float valueToAddThis)
    {
        name = nameValue;
        valueToAdd = valueToAddThis;
    }




    public void Use(Warrior w)
    {
        Debug.Log(name + health + 5);
    }

    public void Use(Wizard wi)
    {
        Debug.Log(name + health + 5);
    }
}
