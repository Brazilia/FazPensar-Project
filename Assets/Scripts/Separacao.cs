using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Separacao : MonoBehaviour
{
    public InputField receberPalavra;
    public Text palavraSeparada;
    private List<string> palavrasSeparada = new List<string>();
    private char[] letras;
    private string palavra;
    private char[] consoante =
        {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L','M',
        'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
    private char[] vogal =
        { 'A', 'E', 'I', 'O', 'U'};
    private int num = 0, proximo = 1;
    private bool prox, addConsoante, addTritongo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("a");
            letras = receberPalavra.text.ToCharArray();
            separar();
            mostrarPalavra();
        }
    }

    void separar()
    {
        Debug.Log(letras.Length);
        for (int i = 0; i < letras.Length; i++)
        {
            Debug.Log(letras[i]);
            Debug.Log(i);
            Debug.Log(letras.Length);
            for (int x = 0; x < vogal.Length; x++)
            {
                if (letras[i] == vogal[x])
                {
                    Debug.Log(proximo);
                    prox = true;
                   if ((i + 2) < letras.Length)
                   {
                        Debug.Log("AAAA");
                        //Caso após vogal tenha rr, ss, sc, sç, xc
                        if (letras[proximo] == 'R' && letras[proximo + 1] == 'R')
                            addConsoante = true;
                        if (letras[proximo] == 'S' && letras[proximo + 1] == 'S')
                            addConsoante = true;
                        if (letras[proximo] == 'S' && letras[proximo + 1] == 'C')
                            addConsoante = true;
                        if (letras[proximo] == 'S' && letras[proximo + 1] == 'Ç')
                            addConsoante = true;
                        if (letras[proximo] == 'X' && letras[proximo + 1] == 'C')
                            addConsoante = true;

                        //Caso após vogal tenha duas consoantes
                        for (int c = 0; c < consoante.Length; c++)
                            if (letras[proximo] == consoante[c])
                                for (int co = 0; co < consoante.Length; co++)
                                    if (letras[proximo + 1] == consoante[co])
                                        addConsoante = true;

                        /*Caso após vogal tenha r, s, n, l, m e nao seja seguido por uma vogal
                        bool vogalAposR = false;
                        for (int v = 0; v < vogal.Length; v++)
                        {
                            if (letras[proximo + 1] == vogal[v])
                                vogalAposR = true;
                        }
                        if (!vogalAposR)
                        {
                            if (letras[proximo] == 'R')
                                addConsoante = true;
                            if (letras[proximo] == 'S')
                                addConsoante = true;
                            if (letras[proximo] == 'N')
                                addConsoante = true;
                            if (letras[proximo] == 'M')
                                addConsoante = true;
                            if (letras[proximo] == 'L')
                                addConsoante = true;
                        }*/

                        //Tritongos
                        if (letras[i] == 'U' && letras[proximo] == 'E' && letras[proximo + 1] == 'I')
                            addTritongo = true;
                        if (letras[i] == 'U' && letras[proximo] == 'A' && letras[proximo + 1] == 'I')
                            addTritongo = true;
                        if (letras[i] == 'U' && letras[proximo] == 'Ã' && letras[proximo + 1] == 'O')
                            addTritongo = true;
                        if (letras[i] == 'U' && letras[proximo] == 'I' && letras[proximo + 1] == 'U')
                            addTritongo = true;
                        if (letras[i] == 'U' && letras[proximo] == 'Õ' && letras[proximo + 1] == 'E')
                            addTritongo = true;
                    }
                   Debug.Log(addConsoante);
                }
            }
            if (prox)
            {
                Debug.Log(addConsoante);
                palavra += letras[i]; //add vogal
                condicoesDeConsoante();
                Debug.Log(addConsoante);
                if (addConsoante)
                {
                    Debug.Log("addConsoante");
                    palavra += letras[proximo]; //add consoante
                    addConsoante = false;
                    i++;
                    proximo++;
                }
                if (addTritongo)
                {
                    Debug.Log("addTritongo");
                    palavra += letras[proximo]; //add consoante
                    palavra += letras[proximo+1]; //add consoante
                    addTritongo = false;
                    i+=2;
                    proximo+= 2;
                }
                if (i == (letras.Length - 2))
                {
                    for (int c = 0; c < consoante.Length; c++)
                        if (letras[proximo] == consoante[c])
                        {
                            palavra += letras[proximo]; //add consoante
                            i++;
                            proximo++;
                        }
                }
                palavrasSeparada.Add(palavra);
                palavra = "";
                prox = false;
                
            }
            else palavra += letras[i];
            proximo++;
        }
    }

    bool condicoesDeConsoante()
    {
        bool excessao = false;
        //ch, lh, nh, qu, gu
        if (addConsoante)
        {
            if (letras[proximo] == 'C' && letras[proximo + 1] == 'H')
                return addConsoante = false;
            if (letras[proximo] == 'L' && letras[proximo + 1] == 'H')
                return addConsoante = false;
            if (letras[proximo] == 'N' && letras[proximo + 1] == 'H')
                return addConsoante = false;
            if (letras[proximo] == 'Q' && letras[proximo + 1] == 'H')
                return addConsoante = false;
            if (letras[proximo] == 'G' && letras[proximo + 1] == 'H')
                return addConsoante = false;

            //Consoante + l é indivisível, com excessão de - ad, ab, sub
            if (letras[proximo] == 'D' && letras[proximo - 1] == 'A' ||
                letras[proximo] == 'B' && letras[proximo - 1] == 'A' ||
                letras[proximo] == 'B' && letras[proximo - 1] == 'U' && letras[proximo - 2] == 'S')
                excessao = true;
            for (int c = 0; c < consoante.Length; c++)
                if (letras[proximo] == consoante[c] && !excessao)
                {
                    if (letras[proximo + 1] == 'L')
                        return addConsoante = false;   
                }

            /*
            if (letras[proximo] == consoante[c] && consoante[c] != 'S' && consoante[c] != 'R' && consoante[c] != 'D')
            {
                if (letras[proximo + 1] == 'V')
                    return addConsoante = false;
                if (letras[proximo + 1] == 'L')
                    return addConsoante = false;
                if (letras[proximo + 1] == 'T')
                    return addConsoante = false;
                if (letras[proximo + 1] == 'M')
                    return addConsoante = false;
                if (letras[proximo + 1] == 'N')
                    return addConsoante = false;
                if (letras[proximo + 1] == 'S')
                    return addConsoante = false;
            }*/
            return addConsoante = true;
        }
        else return addConsoante;
    }

    void mostrarPalavra()
    {
        for (int i = 0; i < palavrasSeparada.Count; i++)
        {
            if (i == 0)
                palavraSeparada.text = palavrasSeparada[i];
            else palavraSeparada.text += "-"+ palavrasSeparada[i];
        }
        palavra = "";
        palavrasSeparada.Clear();
        proximo = 1;
    }
}
