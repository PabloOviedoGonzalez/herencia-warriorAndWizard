using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Warrior santi = new Warrior(); //instancio un nuevo guerrero  "()=constructor por defecto"
        //Debug.Log("Ataque de santi" + santi.attackPower);


        //Warrior sandra = new Warrior(35, 75, 125);
        //Debug.Log("Ataque de Sandra: " + sandra.attackPower);


        //Wizard adri = new Wizard(); //instancio un nuevo mago  "()=constructor por defecto"
        //adri.Attack();
        //adri.AvadaKedabra();


        //Wizard cristiano = new Wizard("cristiano", 300, 10, 10); 
        //Debug.Log("Ataque de santi" + cristiano.magicPower);



        //Wizard[] magos = new Wizard[2];
        //magos[0] = new Wizard();
        //magos[1] = new Wizard("cristiano", 300, 10, 10);

        //foreach(Wizard wi in magos)
        //{
        //    wi.Attack();
        //}


        Warrior warr1 = new Warrior("Inyaky", 100, 100, 55);
        print(warr1.GetHealth());
        warr1.UseAllObjects();
        print(warr1.GetHealth());
        print(warr1.GetArmour());

        //warr1.Attack();

        //Wizard wiz1 = new Wizard("cristiano", 300, 10, 10);
        //print(warr1.GetHealth());

        //List<Personaje> lista = new List<Personaje>();
        //lista.Add(warr1);
        //lista.Add(wiz1);


        //foreach(Personaje personaje in lista)
        //{
        //    print(personaje.GetHealth());
        //}


        //HealthPotion poti = new HealthPotion();
        //poti.Use(wiz1);
        //poti.Use(warr1);
        //poti.Use(warr1);


















    }


   
}
