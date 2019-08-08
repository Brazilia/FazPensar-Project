using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Mistureba : MonoBehaviour
{
    public Text[] dica, palavraEscondida;
    public Text palavraMontadas;
    public Button[] Botoes;
    public Text[] textoDosBotoes;
    private List <string> palavraCompleta = new List<string>();
    private List<char> letrasSemHifen = new List<char>();
    private List<List<char>> listaDeLetrasSemHifen = new List<List<char>>();
    private List<char[]> listaDeLetras = new List<char[]>();
    private string[] palavras;
    private char[] letras;
    private char[] alfabeto =
        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L','M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    private string[,] matrizMisturada = new string[3, 5];
    private bool divisaoEmSeis, ganhou, gameOver, terminar;
    private int imparOuPar, divisao, posicao, numDeEspaçoOcupado, vida;
    private string nome;

    // Start is called before the first frame update
    void Start()
    {
        int tirando = 0; //var utilizada para não dar problema na retirada de hifem das palavras

        for (int i = 0; i < TelaDeCadastro_Mistureba.listaDePalavras.Length; i++) //Passar as perguntas para lista
            palavraCompleta.Add(TelaDeCadastro_Mistureba.listaDePalavras[0]);
        dica[0].text = TelaDeCadastro_Mistureba.listaDeDicas[0];

        Debug.Log("aaaaaaa");
        palavras = new string[palavraCompleta.Count];
        for (int i = 0; i < palavraCompleta.Count; i++)
        {
            Debug.Log(palavraCompleta[i]);
            letras = palavraCompleta[i].ToCharArray();
            letrasSemHifen.Clear();
            for (int x = 0; x < letras.Length; x++)
            {
                letrasSemHifen.Add(letras[x]);
            }
            listaDeLetras.Add(letras);
            for (int x = 0; x < letras.Length; x++) //Adicionar o numero de casas que o vetor terá
                if (letras[x] == '-')
                    numHifens++;
            posHifens = new int[numHifens];
            for (int x = 0; x < letras.Length; x++) //Verificar a posicao dos hifens e guardá-las
                if (letras[x] == '-')
                {
                    posHifens[pos] = x;
                    pos++;
                }
            for (int x = 0; x < numHifens; x++) //Tirando os hifens da lista de silabas
            {
                letrasSemHifen.RemoveAt(posHifens[x] - tirando);
                tirando++;
            }
            numHifens = 0;
            pos = 0;
            posInicial = 0;
            tirando = 0;
            //Adicionando à tela
            Debug.Log(palavraCompleta[i]);
            char c = letrasSemHifen[0];
            palavraEscondida[i].text = c.ToString();
            for (int x = 1; x < letrasSemHifen.Count; x++)
                palavraEscondida[i].text += " _";
            for (int x = 0; x < letrasSemHifen.Count; x++)
                palavras[i] += letrasSemHifen[x].ToString();
            Debug.Log(palavras[i]);
            //dica[x].text = TelaDeCadastro_Mistureba.listaDeDicas[x];
            separarPalavra(listaDeLetras[i]);
            numHifens = 0;
            pos = 0;
            posInicial = 0;
            //listaDeLetrasSemHifen.Add(letrasSemHifen);
            //Debug.Log(listaDeLetrasSemHifen.Count);
        }

        criarMatriz();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            palavraMontadas.text = "";
        }
    }

    System.Random r = new System.Random();
    public void criarMatriz()
    {
        addLetrasAMatriz();
        for (int l = 0; l < matrizMisturada.GetLength(0); l++)
            for (int c = 0; c < matrizMisturada.GetLength(1); c++)
            {
                if (l == 0)
                    textoDosBotoes[0 + c].text = matrizMisturada[l, c];
                if (l == 1)
                    textoDosBotoes[5 + c].text = matrizMisturada[l, c];
                if (l == 2)
                    textoDosBotoes[10 + c].text = matrizMisturada[l, c];
            }
    }

    int numHifens, posInicial, posFinal, pos;
    int[] posHifens;
    bool primeiraRonda;

    public void separarPalavra(char[] letras)
    {
        posInicial = 0;
        posFinal = 0;
        pos = 0;
        primeiraRonda = true;
        for (int x = 0; x < letras.Length; x++)
            if (letras[x] == '-')
                numHifens++;
        Debug.Log(numHifens);
        posHifens = new int[numHifens];
        Debug.Log(posHifens.Length);
        for (int x = 0; x < letras.Length; x++)
            if (letras[x] == '-')
            {
                posHifens[pos] = x;
                pos++;
            }
        for (int i = 0; i < numHifens + 1; i++)
        {
            posInicial = posFinal;
            if (i == numHifens)
                posFinal = letras.Length;
            else posFinal = posHifens[i];
            addPalavraAMatriz(posInicial, posFinal, letras);
        }
    }

    public void addPalavraAMatriz(int posInicial, int posFinal, char[] letras)
    {
        for (int x = 0; x < 1; x++)
        {
            Debug.Log("letras entreges");
            int linha = r.Next(0, matrizMisturada.GetLength(0));
            int coluna = r.Next(0, matrizMisturada.GetLength(1));
            if (matrizMisturada[linha, coluna] == null)
            {
                for (int i = posInicial; i < posFinal; i++)
                {
                    if (primeiraRonda)
                     matrizMisturada[linha, coluna] += letras[i];
                    else if (i != posInicial)
                        matrizMisturada[linha, coluna] += letras[i];
                }
            }
            else x--;
        }
        numDeEspaçoOcupado++;
        Debug.Log(numDeEspaçoOcupado);
        primeiraRonda = false;
    }

    public void addLetrasAMatriz()
    {
        Debug.Log("letras");
        Debug.Log(numDeEspaçoOcupado);
        int rodar = 15 - numDeEspaçoOcupado;
        for (int x = 0; x < rodar; x++)
        {
            int linha = r.Next(0, matrizMisturada.GetLength(0));
            int coluna = r.Next(0, matrizMisturada.GetLength(1));
            if (matrizMisturada[linha, coluna] == null)
                for (int l = 0; l < 3; l++)
                {
                    int num = r.Next(0, alfabeto.Length);
                    matrizMisturada[linha, coluna] += alfabeto[num];
                }
            else x--;
        }
        for (int l = 0; l < matrizMisturada.GetLength(0); l++)
            for (int c = 0; c < matrizMisturada.GetLength(1); c++)
            {
                Debug.Log(matrizMisturada[l, c]);
            }
    }

    //Lista de Botoes
    //
    public void Botao1()
    {
        palavraMontadas.text += matrizMisturada[0, 0];
    }
    public void Botao2()
    {
        palavraMontadas.text += matrizMisturada[0, 1];
    }
    public void Botao3()
    {
        palavraMontadas.text += matrizMisturada[0, 2];
    }
    public void Botao4()
    {
        palavraMontadas.text += matrizMisturada[0, 3];
    }
    public void Botao5()
    {
        palavraMontadas.text += matrizMisturada[0, 4];
    }
    public void Botao6()
    {
        palavraMontadas.text += matrizMisturada[1, 0];
    }
    public void Botao7()
    {
        palavraMontadas.text += matrizMisturada[1, 1];
    }
    public void Botao8()
    {
        palavraMontadas.text += matrizMisturada[1, 2];
    }
    public void Botao9()
    {
        palavraMontadas.text += matrizMisturada[1, 3];
    }
    public void Botao10()
    {
        palavraMontadas.text += matrizMisturada[1, 4];
    }
    public void Botao11()
    {
        palavraMontadas.text += matrizMisturada[2, 0];
    }
    public void Botao12()
    {
        palavraMontadas.text += matrizMisturada[2, 1];

    }
    public void Botao13()
    {
        palavraMontadas.text += matrizMisturada[2, 2];
    }
    public void Botao14()
    {
        palavraMontadas.text += matrizMisturada[2, 3];
    }
    public void Botao15()
    {
        palavraMontadas.text += matrizMisturada[2, 4];
    }
    public void addNaLista()
    {

    }
    //

    // Caso Pressione Botao para verificar
    public void BotaoEnter()
    {
        for (int x = 0; x < palavraCompleta.Count; x++)
            verificarPalavraCerta();
        if (!ganhou)
            if (vida > 0)
                vida--;
            else
                gameOver = true;
        else ganhou = false;
    }
    //Verifica quanto falta para ganhar, ou se já ganhou
    public void verificarPalavraCerta()
    {
        Debug.Log("aaaaaa");
        TelaDeCadastro_Mistureba.numDePerguntas = 1;
        bool palavraCerta = false;
        for (int i = 0; i < palavras.Length; i++)
        {
            if (palavras[i] == palavraMontadas.text)
                palavraCerta = true;
        }
        if (palavraCerta)
        {
            ganhou = true;
            TelaDeCadastro_Mistureba.numDePerguntas--;
            Debug.Log("ganhou");
        }
        else Debug.Log("perdeu");
    }
}
