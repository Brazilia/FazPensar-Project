using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrdenarRespostas : MonoBehaviour
{
    public static string[,] BancoDeDadosDeOrdenar;
    public static string[] OrdemCorreta = new string[4];
    public static string[] OrdemCorretaDePopular = new string[4];
    public static string[] OrdemRandomica = new string[4];
    public Button[] opcoes;
    private int numAcertos, dificuldade, numMatrizPega, numMatrizAtual, numeroRepetido;
    private bool acertouQuestao, iniciarContador, segurandoOpcao;
    private float contador;
    public Text contadorNaTela, pergunta;
    public static string perguntaPassada;
    public Text[] opcoesTexto = new Text[4];
    // Start is called before the first frame update
    System.Random r = new System.Random();
    void Start()
    {
        Temporizador.addTempo(0);
        pergunta.text = perguntaPassada;
        for (int x = 0; x < OrdemCorreta.Length; x++)
        {
            OrdemCorretaDePopular[x] = OrdemCorreta[x];
        }
        for (int x = 0; x < OrdemCorreta.Length; x++)
        {
            Debug.Log(OrdemCorretaDePopular[x]);
        }
        for (int x = 0; x < OrdemRandomica.Length; x++)
        {
            int num = r.Next(0, 4);
            if (num != x)
                verificarNumeros(num, x);
            else x--;
        }
        for (int x = 0; x < OrdemRandomica.Length; x++)
        {
            opcoesTexto[x].text = OrdemRandomica[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (iniciarContador)
        {
            contador -= Time.deltaTime;
            contadorNaTela.text = "0:"+contador.ToString();
        }
        if (acertouQuestao)
        {
            Debug.Log("Você acertou!");
            acertouQuestao = false;
        }
    }

    public void verificarNumeros(int num, int posicao)
    {
        if (OrdemCorretaDePopular[num] != null)
        {
            OrdemRandomica[posicao] = OrdemCorretaDePopular[num];
            OrdemCorretaDePopular[num] = null;
        }
        else
        {
            num = r.Next(0, 4);
            verificarNumeros(num, posicao);
        }
    }
   
    public void BotaoEnter()
    {
        for (int l = 0; l < OrdemRandomica.GetLength(0); l++)
            if (OrdemCorreta[l] == OrdemRandomica[l])
                numAcertos++;
        if (numAcertos == 4)
            acertouQuestao = true;
        else
        {
            numAcertos = 0;
            Debug.Log("Você errou!");
        }
    }
    public void OpcaoMatriz01()
    {
        numMatrizAtual = 0;
        moverOpcoes(numMatrizAtual);
    }
    public void OpcaoMatriz02()
    {
        numMatrizAtual = 1;
        moverOpcoes(numMatrizAtual);

    }
    public void OpcaoMatriz03()
    {
        numMatrizAtual = 2;
        moverOpcoes(numMatrizAtual);

    }
    public void OpcaoMatriz04()
    {
        numMatrizAtual = 3;
        moverOpcoes(numMatrizAtual);

    }
    public void moverOpcoes(int posicaoPega)
    {
        if (!segurandoOpcao)
        {
            numMatrizPega = posicaoPega;
            segurandoOpcao = true;
            Debug.Log(numMatrizPega);
            opcoes[posicaoPega].GetComponent<Image>().color = Color.blue;
        }
        else
        {
            opcoes[numMatrizPega].GetComponent<Image>().color = Color.white;
            Debug.Log(numMatrizAtual);
            string nomeDaOpcaoPega = OrdemRandomica[numMatrizPega];
            string nomeDaOpcaoAtual = OrdemRandomica[numMatrizAtual];
            int lugarNaMatriz = numMatrizPega;
            OrdemRandomica[numMatrizPega] = nomeDaOpcaoAtual; //Muda a matriz
            OrdemRandomica[numMatrizAtual] = nomeDaOpcaoPega; //Muda a matriz
            //Faz com que o texto nos botões sigam a ordem randomica
            for (int x = 0; x < OrdemRandomica.Length; x++)
            {
                opcoesTexto[x].text = OrdemRandomica[x];
            }
            //Mostra a ordem randomica
            for (int i = 0; i < OrdemRandomica.Length; i++)
            {
                Debug.Log(OrdemRandomica[i]);
            }
            segurandoOpcao = false;
        }
    }

}
