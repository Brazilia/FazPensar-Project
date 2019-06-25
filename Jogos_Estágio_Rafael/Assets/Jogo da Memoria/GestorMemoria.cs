using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorMemoria : MonoBehaviour
{
    public bool c1 = true, c2 = true, confirmarTime=false;
    public GameObject carta1, carta2;
    public Text text;
    public int pontos;
    public float timer = 1f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (confirmarTime == true)
        {
            timer -= Time.deltaTime;

        }
      
        text.text = "Pontos: " + pontos;
        if (carta1 != null)
        {
            c1 = false;
        }
        if (carta2 != null)
        {
            c2 = false;
        }
        if (carta1 != null && carta2 != null)
        {
            if (carta1.GetComponent<Cartas>().numerar == carta2.GetComponent<Cartas>().numerar)
            {
                print("Parabens");
                pontos += 1;

                carta1 = null;
                carta2 = null;

                c1 = true;
                c2 = true;
            }
            else
            {
                confirmarTime = true;

                print("Não vei");

                if (timer <= 0.00f)
                {
                    carta1.transform.eulerAngles = new Vector3(0, 0, 0);
                    carta2.transform.eulerAngles = new Vector3(0, 0, 0);

                    carta1.GetComponent<Cartas>().pegar_objeto = true;
                    carta2.GetComponent<Cartas>().pegar_objeto = true;

                    carta1 = null;
                    carta2 = null;

                    c1 = true;
                    c2 = true;
                    confirmarTime = false;
                    timer = 1;
                }
            }
        }
    }
}
