using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conexoes : MonoBehaviour
{
    public static string nomeTag = "null";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BDMatrizes.ganhou == 5)
        {
            cor();
            if (BDMatrizes.ganhou == 5)
            {
                Debug.Log("Ganhou o jogo");
            }
           
        }
        if  (BDMatrizes.perdeu <= 0)
            {
                Debug.Log("Perdeu o jogo");
            }
    }

    public void selecionarObjeto()
    {
        switch (gameObject.tag)
        {
            case "1":
                verificarObjetos(1);
                break;
            case "2":
                verificarObjetos(2);
                break;
            case "3":
                verificarObjetos(3);
                break;
            case "4":
                verificarObjetos(4);
                break;
            case "5":
                verificarObjetos(5);
                break;
        }
    }
    void verificarObjetos(int nome)
    {
        Debug.Log(BDMatrizes.verificarSeCompletou[nome]);
        if (BDMatrizes.verificarSeCompletou[nome] != 1)
            nomeTag = gameObject.tag;
        else nomeTag = "null";
    }
    public void colorirObjetos()
    {
        switch (nomeTag)
        {
            case "1":
                colorir(gameObject, Color.blue, "R1",1);
                break;
            case "2":
                colorir(gameObject, Color.yellow, "R2",2);
                break;
            case "3":
                colorir(gameObject, Color.red, "R3",3);
                break;
            case "4":
                colorir(gameObject, Color.green, "R4",4);
                break;
            case "5":
                colorir(gameObject, Color.magenta, "R5",5);
                break;
        }

    }
    public void colorir(GameObject objeto, Color cor, string nomeReferencia, int num)
    {
        Debug.Log(num);
        if (objeto.tag != nomeReferencia && objeto.tag != nomeTag && gameObject.GetComponent<Image>().color == Color.white)
        {
            if (objeto.tag != "Untagged")
            {
                nomeTag = "null";
                BDMatrizes.perdeu--;
                Debug.Log(BDMatrizes.perdeu);
                apagarCor();
            }
            else
            {
                gameObject.GetComponent<Image>().color = cor;
            }

        }
        else nomeTag = "null";
        if (objeto.tag == nomeReferencia)
        {
            objeto.GetComponent<Image>().color = cor;
            BDMatrizes.ganhou++;
            BDMatrizes.verificarSeCompletou[num] = 1;
            nomeTag = "null";
        }
        
    }

    public void limpar()
    {
        apagarCor();
    }

    public void limparCaminho()
    {
        if (nomeTag != "null")
        {
            apagarCor();
        }
    }
    public void apagarCor()
    {
        for (int i = 0; i < BDMatrizes.imagens.Length; i++)
        {
            if (BDMatrizes.imagens[i].tag == "1" || BDMatrizes.imagens[i].tag == "2" || BDMatrizes.imagens[i].tag == "3" || BDMatrizes.imagens[i].tag == "4" || BDMatrizes.imagens[i].tag == "5")
                ;
            else BDMatrizes.imagens[i].GetComponent<Image>().color = Color.white;
        }
        for (int i = 0; i < BDMatrizes.verificarSeCompletou.Length; i++)
            BDMatrizes.verificarSeCompletou[i] = 0;
        nomeTag = "null";
        BDMatrizes.ganhou = 0;
    }

    public void cor()
    {
        for (int i = 0; i < BDMatrizes.imagens.Length; i++)
        {
            if (BDMatrizes.imagens[i].GetComponent<Image>().color == Color.white)
            {
                BDMatrizes.ganhou = 0;
                Debug.Log("ERROUW");
                apagarCor();
                break;
            }
        }
    }
    

}
