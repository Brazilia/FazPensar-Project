using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Codigo_Turma : MonoBehaviour
    
{
    public List<string> codigos_turma;
    public string guarda_caracteres_turma;
    public int aleatorio_turma;
    public bool guardar_codigo_turma = true;
    public bool guardou_turma;
    


    // Start is called before the first frame update
    void Start()
    {
        

      

    }

    // Update is called once per frame
    void Update()
    {
        if (guardou_turma == false)
        {
            for (int vezes = 0; vezes <= 6; vezes++)
            {
                aleatorio_turma = Random.Range(0, 62);

                if (aleatorio_turma == 0)
                {
                    guarda_caracteres_turma += "a";
                }
                if (aleatorio_turma == 1)
                {
                    guarda_caracteres_turma += "b";
                }
                if (aleatorio_turma == 2)
                {
                    guarda_caracteres_turma += "c";
                }
                if (aleatorio_turma == 3)
                {
                    guarda_caracteres_turma += "d";
                }
                if (aleatorio_turma == 4)
                {
                    guarda_caracteres_turma += "e";
                }
                if (aleatorio_turma == 5)
                {
                    guarda_caracteres_turma += "f";
                }
                if (aleatorio_turma == 6)
                {
                    guarda_caracteres_turma += "g";
                }
                if (aleatorio_turma == 7)
                {
                    guarda_caracteres_turma += "h";
                }
                if (aleatorio_turma == 8)
                {
                    guarda_caracteres_turma += "i";
                }
                if (aleatorio_turma == 9)
                {
                    guarda_caracteres_turma += "j";
                }
                if (aleatorio_turma == 10)
                {
                    guarda_caracteres_turma += "k";
                }
                if (aleatorio_turma == 11)
                {
                    guarda_caracteres_turma += "l";
                }
                if (aleatorio_turma == 12)
                {
                    guarda_caracteres_turma += "m";
                }
                if (aleatorio_turma == 13)
                {
                    guarda_caracteres_turma += "n";
                }
                if (aleatorio_turma == 14)
                {
                    guarda_caracteres_turma += "o";
                }
                if (aleatorio_turma == 15)
                {
                    guarda_caracteres_turma += "p";
                }
                if (aleatorio_turma == 16)
                {
                    guarda_caracteres_turma += "q";
                }
                if (aleatorio_turma == 17)
                {
                    guarda_caracteres_turma += "r";
                }
                if (aleatorio_turma == 18)
                {
                    guarda_caracteres_turma += "s";
                }
                if (aleatorio_turma == 19)
                {
                    guarda_caracteres_turma += "t";
                }
                if (aleatorio_turma == 20)
                {
                    guarda_caracteres_turma += "u";
                }
                if (aleatorio_turma == 21)
                {
                    guarda_caracteres_turma += "v";
                }
                if (aleatorio_turma == 22)
                {
                    guarda_caracteres_turma += "w";
                }
                if (aleatorio_turma == 23)
                {
                    guarda_caracteres_turma += "x";
                }
                if (aleatorio_turma == 24)
                {
                    guarda_caracteres_turma += "y";
                }
                if (aleatorio_turma == 25)
                {
                    guarda_caracteres_turma += "z";
                }
                if (aleatorio_turma == 26)
                {
                    guarda_caracteres_turma += "A";
                }
                if (aleatorio_turma == 27)
                {
                    guarda_caracteres_turma += "B";
                }
                if (aleatorio_turma == 28)
                {
                    guarda_caracteres_turma += "C";
                }
                if (aleatorio_turma == 29)
                {
                    guarda_caracteres_turma += "D";
                }
                if (aleatorio_turma == 30)
                {
                    guarda_caracteres_turma += "E";
                }
                if (aleatorio_turma == 31)
                {
                    guarda_caracteres_turma += "F";
                }
                if (aleatorio_turma == 32)
                {
                    guarda_caracteres_turma += "G";
                }
                if (aleatorio_turma == 33)
                {
                    guarda_caracteres_turma += "H";
                }
                if (aleatorio_turma == 34)
                {
                    guarda_caracteres_turma += "I";
                }
                if (aleatorio_turma == 35)
                {
                    guarda_caracteres_turma += "J";
                }
                if (aleatorio_turma == 36)
                {
                    guarda_caracteres_turma += "K";
                }
                if (aleatorio_turma == 37)
                {
                    guarda_caracteres_turma += "L";
                }
                if (aleatorio_turma == 38)
                {
                    guarda_caracteres_turma += "M";
                }
                if (aleatorio_turma == 39)
                {
                    guarda_caracteres_turma += "N";
                }
                if (aleatorio_turma == 40)
                {
                    guarda_caracteres_turma += "O";
                }
                if (aleatorio_turma == 41)
                {
                    guarda_caracteres_turma += "P";
                }
                if (aleatorio_turma == 42)
                {
                    guarda_caracteres_turma += "Q";
                }
                if (aleatorio_turma == 43)
                {
                    guarda_caracteres_turma += "R";
                }
                if (aleatorio_turma == 44)
                {
                    guarda_caracteres_turma += "S";
                }
                if (aleatorio_turma == 45)
                {
                    guarda_caracteres_turma += "T";
                }
                if (aleatorio_turma == 46)
                {
                    guarda_caracteres_turma += "U";
                }
                if (aleatorio_turma == 47)
                {
                    guarda_caracteres_turma += "V";
                }
                if (aleatorio_turma == 48)
                {
                    guarda_caracteres_turma += "W";
                }
                if (aleatorio_turma == 49)
                {
                    guarda_caracteres_turma += "x";
                }
                if (aleatorio_turma == 50)
                {
                    guarda_caracteres_turma += "y";
                }
                if (aleatorio_turma == 51)
                {
                    guarda_caracteres_turma += "z";
                }
                if (aleatorio_turma == 52)
                {
                    guarda_caracteres_turma += "1";
                }
                if (aleatorio_turma == 53)
                {
                    guarda_caracteres_turma += "2";
                }
                if (aleatorio_turma == 54)
                {
                    guarda_caracteres_turma += "3";
                }
                if (aleatorio_turma == 55)
                {
                    guarda_caracteres_turma += "4";
                }
                if (aleatorio_turma == 56)
                {
                    guarda_caracteres_turma += "5";
                }
                if (aleatorio_turma == 57)
                {
                    guarda_caracteres_turma += "6";
                }
                if (aleatorio_turma == 58)
                {
                    guarda_caracteres_turma += "7";
                }
                if (aleatorio_turma == 59)
                {
                    guarda_caracteres_turma += "8";
                }
                if (aleatorio_turma == 60)
                {
                    guarda_caracteres_turma += "9";
                }
                if (aleatorio_turma == 61)
                {
                    guarda_caracteres_turma += "0";
                }
            }

            for (int vezes = 0; vezes <= codigos_turma.Count - 1; vezes++)
            {
                if (guarda_caracteres_turma == codigos_turma[vezes])
                {
                    guardar_codigo_turma = false;
                }
            }

            if (guardar_codigo_turma == true)
            {
                
                gameObject.GetComponentInChildren<Text>().text = guarda_caracteres_turma; 
                guardou_turma = true;
            }

        }
    }
}
