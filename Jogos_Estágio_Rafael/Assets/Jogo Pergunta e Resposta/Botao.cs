using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Gestor gestor;
    public Listas listas;
    public void Clica()
    {
        if (gameObject.GetComponentInChildren<Text>().text == listas.respostaCorreta[gestor.pergunta_da_vez])
        {

            print("Acertou");
            gestor.ativar = true;
        }
        else
        {
            print("errou");
        }
    }
}
