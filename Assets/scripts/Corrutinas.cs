using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{

    SpriteRenderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        StartCoroutine(Blink());
    }




    IEnumerator Blink()
    {
        while (true)  //bucle infinito para q se repita la corrutina
        {


            for (float i = 1.0f; i >= 0; i -= 0.1f)
            {
                rend.color = new Color(rend.color.r, rend.color.g, rend.color.b, i);

                yield return new WaitForSeconds(0.3f); //pausa la corrutina el tiempo q indicamos y se reanuda en la siguiente linea
            }


            for (float i = 0.0f; i >= 1; i += 0.1f)
            {
                rend.color = new Color(rend.color.r, rend.color.g, rend.color.b, i);

                yield return new WaitForSeconds(0.3f);
            }

            //StartCoroutine(Blink());  // para q vuelva a empezar invocandose a si misma una y otra vez

            yield return null; //se acabo
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
