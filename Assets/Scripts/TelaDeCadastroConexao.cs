using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaDeCadastroConexao : MonoBehaviour
{
    public int num = 0;
    private int numero = 15;
    public static List<int[,]> listaDeMatrizes = new List<int[,]>();
    private int[,] matriz01 = new int[5, 5]{
        {1,1,1,1,1},
        {2,3,3,3,1},
        {2,3,4,4,5},
        {2,4,4,4,5},
        {5,5,5,5,5}
    };
    private int[,] posPergs_Matriz01 = new int[5, 4]{
        {0,0,1,4},
        {1,0,3,0},
        {2,1,1,3},
        {3,1,2,2},
        {4,0,2,4}
    };

    private int[,] matriz02 = new int[5, 5]{
        {1,1,1,3,3},
        {1,2,1,3,4},
        {1,2,3,3,4},
        {1,2,1,5,4},
        {1,1,1,5,5}
    };
    private int[,] posPergs_Matriz02 = new int[5, 4]{
        {1,2,3,2},
        {1,1,3,1},
        {2,2,0,4},
        {3,3,4,4},
        {1,4,3,4}
    };

    private int[,] matriz03 = new int[5, 5]{
        {1,1,3,3,3},
        {1,3,3,5,5},
        {1,1,1,5,2},
        {2,4,4,4,2},
        {2,2,2,2,2}
    };
    private int[,] posPergs_Matriz03 = new int[5, 4]{
        {0,1,2,2},
        {3,0,2,4},
        {1,1,0,4},
        {3,1,3,3},
        {2,3,1,4}
    };

    private int[,] matriz04 = new int[5, 5]{
        {1,2,4,4,4},
        {1,2,5,5,4},
        {1,2,5,5,4},
        {1,3,3,4,4},
        {1,1,3,3,3}
    };
    private int[,] posPergs_Matriz04 = new int[5, 4]{
        {0,0,4,1},
        {0,1,2,1},
        {3,1,4,4},
        {0,2,3,3},
        {1,2,1,3}
    };

    private int[,] matriz05 = new int[5, 5]{
        {1,3,3,3,4},
        {1,1,4,4,4},
        {2,1,4,5,5},
        {2,1,4,5,5},
        {2,2,2,2,2}
    };
    private int[,] posPergs_Matriz05 = new int[5, 4]{
        {0,0,3,1},
        {2,0,4,3},
        {0,1,0,3},
        {0,4,3,2},
        {2,4,4,4}
    };

    private int[,] matriz06 = new int[5, 5]{
        {1,1,1,1,5},
        {2,2,2,1,5},
        {2,3,3,4,5},
        {2,3,4,4,5},
        {2,3,4,5,5}
    };
    private int[,] posPergs_Matriz06 = new int[5, 4]{
        {0,0,1,3},
        {1,2,4,0},
        {2,2,4,1},
        {2,3,4,2},
        {0,4,4,3}
    };

    private int[,] matriz07 = new int[5, 5]{
        {1,1,1,2,3},
        {1,2,2,2,3},
        {1,2,4,4,3},
        {2,2,4,5,3},
        {2,4,4,5,5}
    };
    private int[,] posPergs_Matriz07 = new int[5, 4]{
        {0,2,2,0},
        {0,3,4,0},
        {0,4,3,4},
        {2,3,4,1},
        {3,3,4,4}
    };

    private int[,] matriz08 = new int[5, 5]{
        {1,2,2,2,2},
        {1,1,3,3,2},
        {4,1,1,3,2},
        {4,3,3,3,5},
        {4,3,5,5,5}
    };
    private int[,] posPergs_Matriz08 = new int[5, 4]{
        {0,0,2,2},
        {0,1,2,4},
        {1,2,4,1},
        {2,0,4,0},
        {3,4,4,2}
    };

    private int[,] matriz09 = new int[5, 5]{
        {1,1,1,3,4},
        {1,2,2,3,4},
        {1,2,3,3,4},
        {1,2,3,5,5},
        {1,2,3,5,5}
    };
    private int[,] posPergs_Matriz09 = new int[5, 4]{
        {0,2,4,0},
        {1,2,4,1},
        {0,3,4,2},
        {0,4,2,4},
        {3,3,3,4}
    };

    private int[,] matriz10 = new int[5, 5]{
        {1,1,1,1,1},
        {2,3,3,3,1},
        {2,1,1,1,1},
        {2,1,4,4,5},
        {2,2,4,5,5}
    };
    private int[,] posPergs_Matriz10 = new int[5, 4]{
        {0,0,3,1},
        {1,0,4,1},
        {1,1,1,3},
        {3,3,4,2},
        {4,3,3,4}
    };

    private int[,] matriz11 = new int[5, 5]{
        {1,1,1,1,1},
        {2,2,3,4,5},
        {2,3,3,4,5},
        {2,3,4,4,5},
        {2,2,2,5,5}
    };
    private int[,] posPergs_Matriz11 = new int[5, 4]{
        {0,0,0,4},
        {1,1,4,2},
        {1,2,3,1},
        {1,3,3,2},
        {1,4,4,3}
    };

    private int[,] matriz12 = new int[5, 5]{
        {1,1,1,1,1},
        {1,2,3,3,1},
        {1,2,3,4,4},
        {1,2,4,4,5},
        {1,2,5,5,5}
    };
    private int[,] posPergs_Matriz12 = new int[5, 4]{
        {1,4,4,0},
        {4,1,1,1},
        {1,3,2,2},
        {3,2,2,4},
        {3,4,4,2}
    };

    private int[,] matriz13 = new int[5, 5]{
        {1,1,1,1,1},
        {2,3,4,4,4},
        {2,3,4,5,4},
        {2,3,3,5,5},
        {2,2,3,5,5}
    };
    private int[,] posPergs_Matriz13 = new int[5, 4]{
        {0,0,0,4},
        {1,0,4,1},
        {1,1,4,2},
        {2,4,2,2},
        {3,4,2,3}
    };

    private int[,] matriz14 = new int[5, 5]{
        {1,1,1,1,1},
        {1,2,2,2,1},
        {3,3,3,3,5},
        {3,4,4,4,5},
        {4,4,5,5,5}
    };
    private int[,] posPergs_Matriz14 = new int[5, 4]{
        {1,0,1,4},
        {1,1,1,3},
        {3,0,2,3},
        {4,0,3,3},
        {4,2,2,4}
    };

    private int[,] matriz15 = new int[5, 5]{
        {1,1,1,1,1},
        {1,3,4,4,1},
        {1,3,3,4,5},
        {1,2,3,4,5},
        {2,2,3,5,5}
    };
    private int[,] posPergs_Matriz15 = new int[5, 4]{
        {3,0,1,4},
        {4,0,3,1},
        {4,2,1,1},
        {1,2,3,3},
        {4,3,2,4}
    };

    public InputField[] perguntas;
    public InputField[] respostas;
    public InputField nume;

    // Start is called before the first frame update
    void Awake()
    {
        listaDeMatrizes.Add(matriz01);
        listaDeMatrizes.Add(matriz02);
        listaDeMatrizes.Add(matriz03);
        listaDeMatrizes.Add(matriz04);
        listaDeMatrizes.Add(matriz05);
        listaDeMatrizes.Add(matriz06);
        listaDeMatrizes.Add(matriz07);
        listaDeMatrizes.Add(matriz08);
        listaDeMatrizes.Add(matriz09);
        listaDeMatrizes.Add(matriz10);
        listaDeMatrizes.Add(matriz11);
        listaDeMatrizes.Add(matriz12);
        listaDeMatrizes.Add(matriz13);
        listaDeMatrizes.Add(matriz14);
        listaDeMatrizes.Add(matriz15);
        for (int i = 0; i < 10; i++)
        {
            if (i < 5)
                perguntas[i].text = "";
            else respostas[i - 5].text = "";
        }
    }
    
    System.Random r = new System.Random();
    public void botaoEnter()
    {
        numero = 15;
        for (int i = 0; i < 10; i++)
        {
            if (i < 5 && perguntas[i].text != "")
            {
                BDMatrizes.perguntas[i] = perguntas[i].text;
                Debug.Log(perguntas[i].text);
            }
            else if (i >= 5 && respostas[i - 5].text != "")
            {
                BDMatrizes.respostas[i - 5] = respostas[i - 5].text;
                Debug.Log(respostas[i - 5].text);
            }
            else numero--;
        }
        if (numero == 15)
        {
            int num = r.Next(0, listaDeMatrizes.Count);
            BDMatrizes.matrizRaiz = listaDeMatrizes[num];
            verificarPosicao(num + 1);
            SceneManager.LoadScene("Conexoes");
        }
        else Debug.Log("Escreva os bagus");
    }

    void verificarPosicao(int num)
    {
        switch (num)
        {
            case 1:
                BDMatrizes.matrizRaizDados = posPergs_Matriz01;
                break;
            case 2:
                BDMatrizes.matrizRaizDados = posPergs_Matriz02;
                break;
            case 3:
                BDMatrizes.matrizRaizDados = posPergs_Matriz03;
                break;
            case 4:
                BDMatrizes.matrizRaizDados = posPergs_Matriz04;
                break;
            case 5:
                BDMatrizes.matrizRaizDados = posPergs_Matriz05;
                break;
            case 6:
                BDMatrizes.matrizRaizDados = posPergs_Matriz06;
                break;
            case 7:
                BDMatrizes.matrizRaizDados = posPergs_Matriz07;
                break;
            case 8:
                BDMatrizes.matrizRaizDados = posPergs_Matriz08;
                break;
            case 9:
                BDMatrizes.matrizRaizDados = posPergs_Matriz09;
                break;
            case 10:
                BDMatrizes.matrizRaizDados = posPergs_Matriz10;
                break;
            case 11:
                BDMatrizes.matrizRaizDados = posPergs_Matriz11;
                break;
            case 12:
                BDMatrizes.matrizRaizDados = posPergs_Matriz12;
                break;
            case 13:
                BDMatrizes.matrizRaizDados = posPergs_Matriz13;
                break;
            case 14:
                BDMatrizes.matrizRaizDados = posPergs_Matriz14;
                break;
            case 15:
                BDMatrizes.matrizRaizDados = posPergs_Matriz15;
                break;
        }
    }
}

