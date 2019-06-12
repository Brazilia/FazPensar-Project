using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorizar : MonoBehaviour
{
    public List<GameObject> aleatorizar;
    
    public int range;
    public List<int> vetor;
    // Start is called before the first frame update
    void Start()
    {
        range = aleatorizar.Count;
        vetor.AddRange(new int[] {0,1,2,3,4,5,6,7} );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int aleatorizar_cartas()
    {
        int numero = Random.Range(0, range--);
        int numero_pos = vetor[numero];
        vetor.RemoveAt(numero);
        return numero_pos;
    }
}
