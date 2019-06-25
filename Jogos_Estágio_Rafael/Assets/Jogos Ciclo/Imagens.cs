using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagens : MonoBehaviour
{
    public int numeracao;
    public GestorCiclo gestor;
    public bool chave = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    
    public void OnMouseDrag()
    {
        if (chave==true) {
            Vector3 moverImagem = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            Vector3 posobj = Camera.main.ScreenToWorldPoint(moverImagem);
            transform.position = posobj;
            gestor.imagemDaVez = gameObject;
        }
    }
}
