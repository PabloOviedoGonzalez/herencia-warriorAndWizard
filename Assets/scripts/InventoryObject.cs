using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryObject 
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




    public abstract void Use(Personaje pj);
    
        
    


    public float GetvalueToAdd()
    {
        return valueToAdd;
    }


    public void SetvalueToAdd(float value)
    {
        if (value >= 5 )
            valueToAdd = value;
    }


}
