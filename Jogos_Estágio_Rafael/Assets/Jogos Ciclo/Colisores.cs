using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisores : MonoBehaviour
{
    public int numeracao_pontos;
    public GestorCiclo gestor;
    public Imagens imagens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        print("oi");
        if (gestor.imagemDaVez.GetComponentInChildren<Imagens>().numeracao == numeracao_pontos)
        {
            imagens.chave = false;
            other.transform.parent=null;
        }
    }
}
