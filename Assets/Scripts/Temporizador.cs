using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public Text textoDeTempoNaTela;
    public static float tempoParaAcabar;
    public static bool iniciarContador, pararContador;
    public int dificuldade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pararContador)
        {
            iniciarContador = false;
            tempoEsgotado();
        }
        if(iniciarContador)
        {
            tempoParaAcabar -= Time.deltaTime;
            textoDeTempoNaTela.text = "0:"+tempoParaAcabar.ToString("F0");
            if (tempoParaAcabar < 0)
                pararContador = true;
        }
    }

    public static void addTempo(int dificuldade)
    {
        switch (dificuldade)
        {
            case 0: //Jogo Fácil
                tempoParaAcabar = 15;
                break;
            case 1: //Jogo Médio
                tempoParaAcabar = 10;
                break;
            case 2: //Jogo Dificil
                tempoParaAcabar = 5;
                break;
        }
        iniciarContador = true;
    }
    public void tempoEsgotado()
    {
        pararContador = false;
        Debug.Log("Perdeu");
    }
}
