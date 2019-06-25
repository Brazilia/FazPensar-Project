using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartas : MonoBehaviour
{
    public int numerar;
    public bool pegar_objeto=true;
    public GestorMemoria gestor;
    public Aleatorizar aleatorio;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnMouseDown()
    {
        print("salve");
      
        if (gestor.c1 == true && pegar_objeto == true)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);

            gestor.carta1 = gameObject;
            pegar_objeto = false;
        }
        if(gestor.c1 == false && gestor.c2 == true && pegar_objeto ==true)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);

            gestor.carta2 = gameObject;
            pegar_objeto = false;

            
        }

    }
}
