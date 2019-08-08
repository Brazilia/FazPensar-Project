using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TelaDeCadastro_Mistureba : MonoBehaviour
{
    public static int numDePerguntas, numVidas;
    public static string [] listaDePalavras;
    public static string [] listaDeDicas;

    public Connection Connect;
    public GameObject[] paginasAtivas;
    public GameObject paginasInst;
    public Text vidas, numPagina;
    public InputField[] palavra;
    public InputField[] dica;
    string comando;

    private int paginas, paginasExistentes, vida, verificarResultados = -1;
    private int [] verificacao = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < verificacao.Length; i++)
            verificacao[i] = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (paginas == 0)
        {
            ativarPagina(paginas);
        }
        if (paginas == 1)
        {
            ativarPagina(paginas);
        }
        if (paginas == 2)
        {
            ativarPagina(paginas);
        }
    }

    public void ativarPagina(int num)
    {
        for (int i = 0; i < paginasAtivas.Length; i++)
        {
            if (i == num)
                paginasAtivas[i].SetActive(true);
            else paginasAtivas[i].SetActive(false);
        }
        numPagina.text = "Página " + (paginas+1) + "/" + (paginasExistentes+1);
    }

    public void irDireira()
    {
        if (paginasExistentes == 2)
        {
            if (paginas == 2)
                paginas = 0;
            else paginas++;
        }
        if (paginasExistentes == 1)
        {
            if (paginas == 1)
                paginas = 0;
            else paginas++;
        }
    }
    public void irEsquerda()
    {

        if (paginasExistentes == 2)
        {
            if (paginas == 0)
                paginas = 2;
            else paginas--;
        }
        if (paginasExistentes == 1)
        {
            if (paginas == 0)
                paginas = 1;
            else paginas--;
        }
    }

    public void addPaginas()
    {
        if(paginasExistentes == 2 )
        {
            Debug.Log("Impossivel Adicionar Novas Palavras");
        }
        else
        {
            criarPaginas();
        }
    }
    public void criarPaginas()
    {
            paginasExistentes++;
            paginas = paginasExistentes;
    }

    public void addVidas()
    {
        vida++;
        vidas.text = "Vidas: " + vida;
    }

    public void botaoEnter()
    {
        verificarPagina(paginas);
        Debug.Log(paginasExistentes);
        for (int i = 0; i < paginasExistentes+1; i++)
        {
            Debug.Log(":3");
            if (verificacao[i] != -1)
                verificarResultados++;
        }
        Debug.Log(verificarResultados);
        Debug.Log(paginasExistentes);
        if (verificarResultados == paginasExistentes)
            carregarJogo();
    }

    //Verificar se todos os dados da pagina foram colocados corretamente, individualmente;
    public void verificarPagina(int i)
    {
        Debug.Log("EROOOOOOO");
        if (palavra[i].text != "" && dica[i].text != "")
        {
            bool verificar = false;
            char[] letras = palavra[i].text.ToCharArray();
            for (int x = 0; x < letras.Length; x++)
                if (letras[x] == '-')
                    verificar = true;
            if (verificacao[i] == -1 || verificar == true)
            {
                verificacao[i] = 1;
                palavra[i].GetComponent<Image>().color = Color.green;
                dica[i].GetComponent<Image>().color = Color.green;
            }

        }
        else Debug.Log("Erro! Preencha os campos corretamente");
    }
    public void carregarJogo()
    {
        Debug.Log("Ganhei :3");
        for (int i = 0; i <= paginasExistentes; i++)
        {
            Debug.Log("mano:   " +palavra[i].textComponent.text);
            listaDePalavras = new string[paginasExistentes+1];
            listaDePalavras[i] = palavra[i].textComponent.text;
            listaDeDicas = new string[paginasExistentes + 1];
            listaDeDicas[i] = dica[i].textComponent.text;
            comando = "INSERT into mistureba (DicaPalavra, Palavra, Vida) VALUES ('" + listaDeDicas[0] + "', '" + listaDePalavras[0] + "', '" + vida + "');";
            Debug.Log(comando);
            Connect.Conecta_Banco(comando);
        }
        numVidas = vida;
        numDePerguntas = paginasExistentes+1;
        SceneManager.LoadScene("Mistureba");
    }
}
