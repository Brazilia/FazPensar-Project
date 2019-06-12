using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seta : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (chave == true)
        {
            if (gameObject.CompareTag("Cima"))
            {
                imagemFundo.transform.position= new Vector3(imagemFundo.transform.position.x, Mathf.MoveTowards(imagemFundo.transform.position.y,
                    pontoCima.transform.position.y,velocidadeSetas * Time.deltaTime), 0);
            }
            if (gameObject.CompareTag("Baixo"))
            {
                imagemFundo.transform.position = new Vector3(imagemFundo.transform.position.x, Mathf.MoveTowards(imagemFundo.transform.position.y,
                   pontoBaixo.transform.position.y, velocidadeSetas * Time.deltaTime), 0);
            }

        }

    }

    public GameObject imagemFundo;
    public Transform pontoCima;
    public Transform pontoBaixo;
    public int velocidadeSetas;
    public bool chave = false;

    public void OnMouseDown()
    {
        
        if (imagemFundo.transform.position.y <= pontoBaixo.position.y && imagemFundo.transform.position.y >= pontoCima.position.y)
        {

            chave = false;
        }
        else
        {
            chave = true;
        }
    }
    public void OnMouseExit()
    {
        chave = false;
    }

}