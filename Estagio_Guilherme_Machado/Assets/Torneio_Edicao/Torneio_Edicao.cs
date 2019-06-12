using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Torneio_Edicao : MonoBehaviour
{
    public List<string> niveis;
    public Toggle quatro;
    public Toggle oito;
    public Toggle doze;
    public Button confirmar;
    public Button adicionar;
    public Button seta1;
    public Button seta2;
    public List<Button> botoes_adicionar;
    public Text nivel;
    public Text participante;
    public int qtd_chaves;
    public List<Text> participantes;
    public GameObject ponto_inic_inte;
    public GameObject ponto_inic_bot;

    // Start is called before the first frame update
    void Start()
    {
        niveis.Add("estadual");
        niveis.Add("municipal");
        confirmar.onClick.AddListener(confirmando);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confirmando()
    {
        SceneManager.LoadScene("Torneio_Chaves");
    }
}
