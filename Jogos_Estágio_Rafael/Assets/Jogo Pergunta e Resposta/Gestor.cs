using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gestor : MonoBehaviour
{
    public Text pergunta;
    public List<Button> buttons;
    public Listas listas;
    public int pergunta_da_vez;

    List<int> vetor = new List<int>();
    int range = 4;

    public bool ativar=true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (ativar == true)
        {
            vetor.AddRange(new int[] { 0, 1, 2, 3 });

            pergunta.text = listas.perguntas[randomizar_pergunta()];

            buttons[aleatorizar_por_listas()].GetComponentInChildren<Text>().text = listas.respostaCorreta[pergunta_da_vez];
            buttons[aleatorizar_por_listas()].GetComponentInChildren<Text>().text = listas.respstaFalsa1[pergunta_da_vez];
            buttons[aleatorizar_por_listas()].GetComponentInChildren<Text>().text = listas.respstaFalsa2[pergunta_da_vez];
            buttons[aleatorizar_por_listas()].GetComponentInChildren<Text>().text = listas.respstaFalsa3[pergunta_da_vez];

            ativar = false;
        }
        range = 4;
       
    }

    public int randomizar_pergunta()
    {
        pergunta_da_vez = Random.Range(0, listas.perguntas.Count);
        return pergunta_da_vez;
    }

    public int aleatorizar_por_listas()
    {
        int sorteio = Random.Range(0, range--);
        int valorDoSorteio = vetor[sorteio];
        vetor.RemoveAt(sorteio);
        return valorDoSorteio;
    }
    
}
