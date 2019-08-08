using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


/*
Escolha o caminho através da URL
Escolha o comando deseja através do comando_mysql   
Chame a função Conecta_Banco(comando_mysql)  

    necessário o uso dos scripts php de conexão e de comandos mysql armazenados no repositório do banco de dados.
    script de conexão sendo utilizado: connection.php
    scrip de comandos mysql sendo utilizado: teste.php
*/


public class Connection : MonoBehaviour
{    

    string URL = "https://fabricadejogosntem2019.000webhostapp.com/Teste_Jogos.php/";
    public string comando_mysql;
    public string[] returnedData;
    public string dadoRetornado;
    
    string[] stringSeparators = new string[] {};

    //"select * from testando"
    //"delete from testando where id = 2"
    //"insert into testando (nome,email,pontuacao) values ('Daniel','daniel@hotmail.com','100')"

    void Start()
    {
        //StartCoroutine(SelectData(comando_mysql));
        dadoRetornado = Conecta_Banco(comando_mysql);
    }    

    // verifica qual comando deve ser chamado
    public string Conecta_Banco(string texto)
    {
        if(VerificaComando(texto) != "select")
        {
            StartCoroutine(Insert_Delete_Update(texto));
        }
        else if(VerificaComando(texto) == "select")
        {
            StartCoroutine(SelectData(texto));
        }
        return dadoRetornado;
    }

    //substitui caracteres especiais que não são convertidos
    private string ArrumaTexto(string texto)
    {
        texto = texto.Replace("%20", " ");          
        texto = texto.Replace("%21", "!");  
        texto = texto.Replace("%22", "");
        texto = texto.Replace("%23", "#");
        texto = texto.Replace("%24", "$");
        texto = texto.Replace("%25", "%");
        texto = texto.Replace("%26", "&");
        texto = texto.Replace("%27", "'");
        texto = texto.Replace("%28", "(");
        texto = texto.Replace("%29", ")");
        texto = texto.Replace("%2A", "*");
        texto = texto.Replace("%2B", "+");
        texto = texto.Replace("%2C", ",");
        texto = texto.Replace("%2D", "-");
        texto = texto.Replace("%2E", ".");
        texto = texto.Replace("%2F", "/");
        texto = texto.Replace("%3A", ":");
        texto = texto.Replace("%3B", ";");
        texto = texto.Replace("%3C", "<");
        texto = texto.Replace("%3D", "=");
        texto = texto.Replace("%3E", ">");
        texto = texto.Replace("%3F", "?");
        texto = texto.Replace("%40", "@");

        texto = texto.Replace("%5B", "[");
        texto = texto.Replace("%5C", "\"");
        texto = texto.Replace("%5D", "]");
        texto = texto.Replace("%5E", "^");
        texto = texto.Replace("%60", "`");
        texto = texto.Replace("%7B", "{");


        texto = texto.Replace("%E0", "à");
        texto = texto.Replace("%E1", "á");
        texto = texto.Replace("%E2", "â");
        texto = texto.Replace("%E3", "ã");
        texto = texto.Replace("%C0", "À");
        texto = texto.Replace("%C1", "Á");
        texto = texto.Replace("%C2", "Â");
        texto = texto.Replace("%C3", "Ã");

        texto = texto.Replace("%E8", "è");
        texto = texto.Replace("%E9", "é");
        texto = texto.Replace("%EA", "ê");
        texto = texto.Replace("%C8", "È");
        texto = texto.Replace("%C9", "É");
        texto = texto.Replace("%CA", "Ê");

        texto = texto.Replace("%EC", "ì");
        texto = texto.Replace("%ED", "ì");
        texto = texto.Replace("%EE", "î");
        texto = texto.Replace("%CC", "Ì");
        texto = texto.Replace("%CD", "Í");
        texto = texto.Replace("%CE", "Î");

        texto = texto.Replace("%F2", "ò");
        texto = texto.Replace("%F3", "ó");
        texto = texto.Replace("%F4", "ô");
        texto = texto.Replace("%F5", "õ");
        texto = texto.Replace("%D2", "Ò");
        texto = texto.Replace("%D3", "Ó");
        texto = texto.Replace("%D4", "Ô");
        texto = texto.Replace("%D5", "Õ");

        texto = texto.Replace("%F9", "ù");
        texto = texto.Replace("%FA", "ú");
        texto = texto.Replace("%FB", "û");
        texto = texto.Replace("%D9", "Ù");
        texto = texto.Replace("%DA", "Ú");
        texto = texto.Replace("%DB", "Û");

        return texto;
    }

    
    //verifica qual o comando mysql que foi passado
    private string VerificaComando(string texto)
    {
        string tipo = texto.Substring(0, texto.IndexOf(" "));        
        return tipo;
    }

    

    //função utilizada para inserir, ou deletar, ou atualizar dados
    IEnumerator Insert_Delete_Update(string comando)
    {
        WWWForm form = new WWWForm();
        form.AddField("commandLine", comando);

        using (UnityWebRequest www = UnityWebRequest.Post(URL, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
                Debug.Log(www.downloadHandler.text);
                dadoRetornado = www.downloadHandler.text;
            }
            
        }
    }

    //seleciona os dados do banco
    IEnumerator SelectData(string comando)
    {        
        WWWForm form = new WWWForm();
        form.AddField("commandLine", comando);        

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        www.chunkedTransfer = false;
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            
            Debug.Log("Connected");

            dadoRetornado = ArrumaTexto(www.downloadHandler.text);
            Debug.Log(ArrumaTexto(dadoRetornado));
        
            
            
    
            //arruma o texto, tirando colchetes, aspas e chaves
            returnedData = dadoRetornado.Split(stringSeparators, StringSplitOptions.None);            
            for(int i = 0; i < returnedData.Length - 1; i++)
            {                                
                if (returnedData[i].StartsWith("|"))
                {
                    returnedData[i] = returnedData[i].Remove(0,1);
                                   
                }
                print("Returned:" + returnedData[i]);
            }
        }

        

        //WWW www = new WWW(URL, form);
    }

    //envia dados para o banco de dados
    //IEnumerator InputData(string[] inputs)
    //{

    //    for (int i = 0; i <= inputs.Length; i++)
    //    {
    //        textoMySQL.text += inputs[i];
    //    }
    //    WWWForm form = new WWWForm();
    //    form.AddField("commandLine", textoMySQL.text);

    //    using (UnityWebRequest www = UnityWebRequest.Post(URL, form))
    //    {
    //        yield return www.SendWebRequest();

    //        if (www.isNetworkError || www.isHttpError)
    //        {
    //            Debug.Log(www.error);
    //        }
    //        else
    //        {
    //            Debug.Log("Form upload complete!");
    //        }
    //    }
    //}

    //string GetValueData(string data, string index)
    //{
    //    string value = data.Substring(data.IndexOf(index) + index.Length);
    //    if (value.Contains("|"))
    //    {
    //        value = value.Remove(value.IndexOf("|"));
    //    }
    //    return value;
    //}
}
