using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TelaDeCadastro_Reorganizar : MonoBehaviour
{
    public Text[] opcoes;
    public Text pergunta;
    public string perguntaFuncionaCaralho;
    public void BotaoEnter()
    {
        for (int x = 0; x < OrdenarRespostas.OrdemCorreta.Length; x++)
        {
            OrdenarRespostas.OrdemCorreta[x] = opcoes[x].text;
        }
        perguntaFuncionaCaralho = pergunta.text;
        OrdenarRespostas.perguntaPassada = perguntaFuncionaCaralho;
        SceneManager.LoadScene("Reorganizar");
    }

}
