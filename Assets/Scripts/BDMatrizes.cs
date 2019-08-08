using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BDMatrizes : MonoBehaviour
{

    //Script executado antes do jogo iniciar, após receber dados do professor
    private int x = 0;
    private bool converterVetor = true;
    private Image[,] transformarVetorEmMatriz = new Image[5, 5];
    public Image[] eslotes;
    public static string[] perguntas = new string[5]; //perguntas escritas pelo professor
    public static string[] respostas = new string [5]; //respostas escritas pelo professor
    public static int[,] matrizRaiz; //matriz randomizada
    public static int[,] matrizRaizDados; //posicao das perguntas/ respostas na matriz
    public static Image[] compartilharEslotes;
    public static int ganhou = 0;
    public static int perdeu = 2;
    public static int[] verificarSeCompletou = new int[6];
    public static Image[] imagens = new Image[25];
    public static bool ativar = false;
    // Start is called before the first frame update
    void Start()
    {
        converter(matrizRaiz);
        procurarPalavras(matrizRaizDados);
    }
    
    public void converter(int[,] matriz)
    {
        int x = 0;
        for (int l = 0; l < matriz.GetLength(0); l++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                if (converterVetor)
                {
                    transformarVetorEmMatriz[l, c] = eslotes[c + x];
                }
                else
                {
                    eslotes[c + x] = transformarVetorEmMatriz[l, c];
                    imagens[c + x] = eslotes[c + x];
                }
            }
            x += 5;
        }
    }
    public void procurarPalavras(int[,] matrizDados)
    {
        int num = 0; // vez da pergunta ou resposta
        for (int l = 0; l < matrizDados.GetLength(0); l++)
        {
            if (num == 0)
            {
                int perguntaPosA = matrizDados[l, 0];
                int perguntaPosB = matrizDados[l, 1];
                converterMatrizEmVetor(transformarVetorEmMatriz, perguntaPosA, perguntaPosB, l, num);
                num++;
                l--;
            }
            else
            {
                int perguntaPosA = matrizDados[l, 2];
                int perguntaPosB = matrizDados[l, 3];
                converterMatrizEmVetor(transformarVetorEmMatriz, perguntaPosA, perguntaPosB, l, num);
                num--;
            }
        }
    }
    public void converterMatrizEmVetor(Image[,] matrizDeReferencia, int posX, int posY, int posPerg, int num) // Colocar palavras no local certo
    {
        int localVetor;
        Debug.Log(posY);
        Debug.Log(posPerg);
        switch (posPerg)
        {
            case 0:
                localVetor = 0;
                Debug.Log(localVetor + posY);
                conversorSimples(matrizDeReferencia, posX, posY, posPerg, num, Color.blue, "1", "R1");
                break;
            case 1:
                localVetor = 5;
                Debug.Log(localVetor + posY);
                conversorSimples(matrizDeReferencia, posX, posY, posPerg, num, Color.yellow, "2", "R2");
                break;
            case 2:
                localVetor = 10;
                Debug.Log(localVetor + posY);
                conversorSimples(matrizDeReferencia, posX, posY, posPerg, num, Color.red, "3", "R3");
                break;
            case 3:
                localVetor = 15;
                Debug.Log(localVetor + posY);
                conversorSimples(matrizDeReferencia, posX, posY, posPerg, num, Color.green, "4", "R4");
                break;
            case 4:
                localVetor = 20;
                Debug.Log(localVetor + posY);
                conversorSimples(matrizDeReferencia, posX, posY, posPerg, num, Color.magenta, "5", "R5");
                break;

        }
        converterVetor = false;
        converter(matrizRaiz);
    }
    public void conversorSimples(Image[,] matrizDeReferencia, int posX, int posY, int posPerg, int num, Color cor, string tagPerg, string tagResp)
    {
        if (num == 0)
        {
            matrizDeReferencia[posX, posY].GetComponent<Image>().color = cor;
            matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = tagPerg;
            matrizDeReferencia[posX, posY].tag = tagPerg;
            matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = perguntas[posPerg];
        }
        else
        {
            matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = tagResp;
            matrizDeReferencia[posX, posY].tag = tagResp;
            matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = respostas[posPerg];
        }

    }
}


/*
 * 
 *         switch (posPerg)
        {
            case 0:
                localVetor = 0;
                Debug.Log(localVetor + posY);
                if (num == 0)
                {
                    matrizDeReferencia[posX, posY].GetComponent<Image>().color = Color.blue;
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "1";
                    matrizDeReferencia[posX, posY].tag = "1";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = perguntas[posPerg];
                }
                else
                {
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "R1";
                    matrizDeReferencia[posX, posY].tag = "R1";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = respostas[posPerg];
                }
                break;
            case 1:
                localVetor = 5;
                Debug.Log(localVetor + posY);
                if (num == 0)
                {
                    matrizDeReferencia[posX, posY].GetComponent<Image>().color = Color.yellow;
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "2";
                    matrizDeReferencia[posX, posY].tag = "2";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = perguntas[posPerg];
                }
                else
                {
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "R2";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = respostas[posPerg];
                }
                break;
            case 2:
                localVetor = 10;
                Debug.Log(localVetor + posY);
                if (num == 0)
                {
                    matrizDeReferencia[posX, posY].GetComponent<Image>().color = Color.red;
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "3";
                    matrizDeReferencia[posX, posY].tag = "3";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = perguntas[posPerg];
                }
                else
                {
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "R3";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = respostas[posPerg];
                }
                break;
            case 3:
                localVetor = 15;
                Debug.Log(localVetor + posY);
                if (num == 0)
                {
                    matrizDeReferencia[posX, posY].GetComponent<Image>().color = Color.green;
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "4";
                    matrizDeReferencia[posX, posY].tag = "4";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = perguntas[posPerg];
                }
                else
                {
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "R4";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = respostas[posPerg];
                }
                break;
            case 4:
                localVetor = 20;
                Debug.Log(localVetor + posY);
                if (num == 0)
                {
                    matrizDeReferencia[posX, posY].GetComponent<Image>().color = Color.magenta;
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "5";
                    matrizDeReferencia[posX, posY].tag = "5";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = perguntas[posPerg];
                }
                else
                {
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().tag = "R5";
                    matrizDeReferencia[posX, posY].GetComponentInChildren<Text>().text = respostas[posPerg];
                }
                break;

        }

for (int l = 0; l < matriz.GetLength(0); l++)
{
    for (int c = 0; c < matriz.GetLength(1); c++)
    {
        switch (matriz[l, c])
        {
            case 1:
                eslotes[c + x].GetComponent<Image>().color = Color.blue;
                break;
            case 2:
                eslotes[c + x].GetComponent<Image>().color = Color.yellow;
                break;
            case 3:
                eslotes[c + x].GetComponent<Image>().color = Color.red;
                break;
            case 4:
                eslotes[c + x].GetComponent<Image>().color = Color.green;
                break;
            case 5:
                eslotes[c + x].GetComponent<Image>().color = Color.magenta;
                break;
        }
    }
    x += 5;
}*/
