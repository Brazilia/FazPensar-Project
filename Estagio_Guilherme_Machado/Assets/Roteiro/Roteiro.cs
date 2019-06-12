using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roteiro : MonoBehaviour
{
    public Codigo_Roteiro codigo_roteiro;
    public Button volta;
    public Button confirmar;

    public List<string> materia;
    public List<string> nivel;
    public List<string> pergunta;
    public List<string> serie;

    public InputField input_materia;
    public InputField input_pergunta;
    public InputField input_dificuldade;
    public InputField input_serie;

    public bool permissao = false;

    // Start is called before the first frame update
    void Start()
    {
        codigo_roteiro = GameObject.Find("Codigo").GetComponent<Codigo_Roteiro>();
    }

    // Update is called once per frame
    void Update()
    {
        volta.onClick.AddListener(Voltando);
        confirmar.onClick.AddListener(Confirmando);
        permissao = false;
    }

    private void Confirmando()
    {
        if (permissao == false)
        {
            materia.Add(input_materia.text);
            input_materia.text = "";

            pergunta.Add(input_pergunta.text);
            input_pergunta.text = "";

            nivel.Add(input_dificuldade.text);
            input_dificuldade.text = "";

            serie.Add(input_serie.text);
            input_serie.text = "";

            codigo_roteiro.codigos_roteiro.Add(codigo_roteiro.guarda_caracteres_roteiro);

            permissao = true;
        }
    }

    private void Voltando()
    {

    }
}
