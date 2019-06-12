using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinglePlayer : MonoBehaviour
{
    public Button confirmando;
    public Button Voltando;
    public Button m_seta1;
    public Button m_seta2;
    public Button perg_seta1;
    public Button perg_seta2;
    public Button dif_seta1;
    public Button dif_seta2;
    public Button ser_seta1;
    public Button ser_seta2;

    public Text materia;
    public Text pergunta;
    public Text dificuldade;
    public Text serie;

    public List<string> lista_materias;
    public List<int> lista_pergunta;
    public List<int> lista_dificuldade;
    public List<string> lista_serie;

    public int indice_mat;
    public int indice_perg;
    public int indice_dif;
    public int indice_ser;

    public string materia_selecionada;
    public int perguntas_selecionadas;
    public int dificuldade_selecionada;
    public string serie_selecionada;

    public bool permissao = false;



    // Start is called before the first frame update
    void Start()
    {
        lista_materias.Add("matematica");
        lista_materias.Add("ciencia");
        lista_materias.Add("portugues");
        materia.text = lista_materias[indice_mat];

        lista_pergunta.Add(4);
        lista_pergunta.Add(8);
        lista_pergunta.Add(16);
        pergunta.text = lista_pergunta[indice_perg].ToString();

        lista_dificuldade.Add(1);
        lista_dificuldade.Add(2);
        lista_dificuldade.Add(3);
        dificuldade.text = lista_dificuldade[indice_dif].ToString();

        lista_serie.Add("5°");
        lista_serie.Add("6°");
        lista_serie.Add("7°");
        serie.text = lista_serie[indice_ser];
    }

    // Update is called once per frame
    void Update()
    {
        m_seta1.onClick.AddListener(M_seta1_click);
        m_seta2.onClick.AddListener(M_seta2_click);
        perg_seta1.onClick.AddListener(Perg_seta1_click);
        perg_seta2.onClick.AddListener(Perg_seta2_click);
        dif_seta1.onClick.AddListener(Dif_seta1_click);
        dif_seta2.onClick.AddListener(Dif_seta2_click);
        ser_seta2.onClick.AddListener(Ser_seta2_click);
        ser_seta1.onClick.AddListener(Ser_seta1_click);
        confirmando.onClick.AddListener(Confirmando_Click);
        permissao = false;



}

    public void M_seta1_click()
    {
       

        if (indice_mat != -1 && permissao == false)
        {
            indice_mat--;
            permissao = true;

            if (indice_mat == -1)
            {
                indice_mat = lista_materias.Count - 1;

            }
        }
        

        materia.text = lista_materias[indice_mat];
    }

    public void M_seta2_click()
    {
        if (indice_mat != lista_materias.Count + 1 && permissao == false)
        {
            indice_mat += 1;
            permissao = true;
            
        }
        if (indice_mat == lista_materias.Count)
        {
            
            indice_mat = 0;
        }
        
            materia.text = lista_materias[indice_mat];
        
        
    }

    public void Perg_seta1_click()
    {
        if (indice_perg != -1 && permissao == false)
        {
            indice_perg--;
            permissao = true;

            if (indice_perg == -1)
            {
                indice_perg = lista_pergunta.Count - 1;

            }
        }


        pergunta.text = lista_pergunta[indice_perg].ToString();

    }

    public void Perg_seta2_click()
    {
        if (indice_perg != lista_pergunta.Count + 1 && permissao == false)
        {
            indice_perg += 1;
            permissao = true;

        }
        if (indice_perg == lista_pergunta.Count)
        {

            indice_perg = 0;
        }

        pergunta.text = lista_pergunta[indice_perg].ToString();

    }


    public void Dif_seta2_click()
    {
        if (indice_dif != lista_dificuldade.Count + 1 && permissao == false)
        {
            indice_dif += 1;
            permissao = true;

        }
        if (indice_dif == lista_dificuldade.Count)
        {

            indice_dif = 0;
        }

        dificuldade.text = lista_dificuldade[indice_dif].ToString();
    }

    public void Dif_seta1_click()
    {
        if (indice_dif != -1 && permissao == false)
        {
            indice_dif--;
            permissao = true;

            if (indice_dif == -1)
            {
                indice_dif = lista_dificuldade.Count - 1;

            }
        }


        dificuldade.text = lista_dificuldade[indice_dif].ToString();
    }

    public void Ser_seta1_click()
    {
        if (indice_ser != -1 && permissao == false)
        {
            indice_ser--;
            permissao = true;

            if (indice_ser == -1)
            {
                indice_ser = lista_serie.Count - 1;

            }
        }


        serie.text = lista_serie[indice_ser];
    }

    public void Ser_seta2_click()
    {
        if (indice_ser != lista_serie.Count + 1 && permissao == false)
        {
            indice_ser += 1;
            permissao = true;

        }
        if (indice_ser == lista_serie.Count)
        {

            indice_ser = 0;
        }

        serie.text = lista_serie[indice_ser];
    }

    private void Confirmando_Click()
    {
        if (permissao == false)
        {
            materia_selecionada = lista_materias[indice_mat];
            perguntas_selecionadas = lista_pergunta[indice_perg];
            dificuldade_selecionada = lista_dificuldade[indice_dif];
            serie_selecionada = lista_serie[indice_ser];
            permissao = true;
        }
    }
}
