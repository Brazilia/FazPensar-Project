using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EdicaoTurma : MonoBehaviour
{
    public Codigo_Turma codigo_turma;
    public Button voltar;
    public Button confirmar;

    public List<string> nome;
    public List<string> serie_turma;

    public InputField input_nome;
    public InputField input_serie;

    public bool permissao = false;


    // Start is called before the first frame update
    void Start()
    {
        codigo_turma = GameObject.Find("codigo").GetComponent<Codigo_Turma>();
    }

    // Update is called once per frame
    void Update()
    {
       //oltar.onClick.AddListener(Voltando);
        confirmar.onClick.AddListener(Confirmando);
        permissao = false;
    }

    private void Confirmando()
    {
        if (permissao == false)
        {

            nome.Add(input_nome.text);
            input_nome.text = "";

            serie_turma.Add(input_serie.text);
            input_serie.text = "";
            permissao = true;

            codigo_turma.codigos_turma.Add(codigo_turma.guarda_caracteres_turma);

            
           
        }
        

        
    }

    private void Voltando()
    {

    }
}
