using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Codigo_Roteiro : MonoBehaviour
{
    public List<string> codigos_roteiro;
    public string guarda_caracteres_roteiro;
    public int aleatorio_roteiro;
    public bool guardar_codigo_roteiro = true;
    public bool guardou_roteiro;



    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        if (guardou_roteiro == false)
        {
            for (int vezes = 0; vezes <= 6; vezes++)
            {
                aleatorio_roteiro = Random.Range(0, 62);

                if (aleatorio_roteiro == 0)
                {
                    guarda_caracteres_roteiro += "a";
                }
                if (aleatorio_roteiro == 1)
                {
                    guarda_caracteres_roteiro += "b";
                }
                if (aleatorio_roteiro == 2)
                {
                    guarda_caracteres_roteiro += "c";
                }
                if (aleatorio_roteiro == 3)
                {
                    guarda_caracteres_roteiro += "d";
                }
                if (aleatorio_roteiro == 4)
                {
                    guarda_caracteres_roteiro += "e";
                }
                if (aleatorio_roteiro == 5)
                {
                    guarda_caracteres_roteiro += "f";
                }
                if (aleatorio_roteiro == 6)
                {
                    guarda_caracteres_roteiro += "g";
                }
                if (aleatorio_roteiro == 7)
                {
                    guarda_caracteres_roteiro += "h";
                }
                if (aleatorio_roteiro == 8)
                {
                    guarda_caracteres_roteiro += "i";
                }
                if (aleatorio_roteiro == 9)
                {
                    guarda_caracteres_roteiro += "j";
                }
                if (aleatorio_roteiro == 10)
                {
                    guarda_caracteres_roteiro += "k";
                }
                if (aleatorio_roteiro == 11)
                {
                    guarda_caracteres_roteiro += "l";
                }
                if (aleatorio_roteiro == 12)
                {
                    guarda_caracteres_roteiro += "m";
                }
                if (aleatorio_roteiro == 13)
                {
                    guarda_caracteres_roteiro += "n";
                }
                if (aleatorio_roteiro == 14)
                {
                    guarda_caracteres_roteiro += "o";
                }
                if (aleatorio_roteiro == 15)
                {
                    guarda_caracteres_roteiro += "p";
                }
                if (aleatorio_roteiro == 16)
                {
                    guarda_caracteres_roteiro += "q";
                }
                if (aleatorio_roteiro == 17)
                {
                    guarda_caracteres_roteiro += "r";
                }
                if (aleatorio_roteiro == 18)
                {
                    guarda_caracteres_roteiro += "s";
                }
                if (aleatorio_roteiro == 19)
                {
                    guarda_caracteres_roteiro += "t";
                }
                if (aleatorio_roteiro == 20)
                {
                    guarda_caracteres_roteiro += "u";
                }
                if (aleatorio_roteiro == 21)
                {
                    guarda_caracteres_roteiro += "v";
                }
                if (aleatorio_roteiro == 22)
                {
                    guarda_caracteres_roteiro += "w";
                }
                if (aleatorio_roteiro == 23)
                {
                    guarda_caracteres_roteiro += "x";
                }
                if (aleatorio_roteiro == 24)
                {
                    guarda_caracteres_roteiro += "y";
                }
                if (aleatorio_roteiro == 25)
                {
                    guarda_caracteres_roteiro += "z";
                }
                if (aleatorio_roteiro == 26)
                {
                    guarda_caracteres_roteiro += "A";
                }
                if (aleatorio_roteiro == 27)
                {
                    guarda_caracteres_roteiro += "B";
                }
                if (aleatorio_roteiro == 28)
                {
                    guarda_caracteres_roteiro += "C";
                }
                if (aleatorio_roteiro == 29)
                {
                    guarda_caracteres_roteiro += "D";
                }
                if (aleatorio_roteiro == 30)
                {
                    guarda_caracteres_roteiro += "E";
                }
                if (aleatorio_roteiro == 31)
                {
                    guarda_caracteres_roteiro += "F";
                }
                if (aleatorio_roteiro == 32)
                {
                    guarda_caracteres_roteiro += "G";
                }
                if (aleatorio_roteiro == 33)
                {
                    guarda_caracteres_roteiro += "H";
                }
                if (aleatorio_roteiro == 34)
                {
                    guarda_caracteres_roteiro += "I";
                }
                if (aleatorio_roteiro == 35)
                {
                    guarda_caracteres_roteiro += "J";
                }
                if (aleatorio_roteiro == 36)
                {
                    guarda_caracteres_roteiro += "K";
                }
                if (aleatorio_roteiro == 37)
                {
                    guarda_caracteres_roteiro += "L";
                }
                if (aleatorio_roteiro == 38)
                {
                    guarda_caracteres_roteiro += "M";
                }
                if (aleatorio_roteiro == 39)
                {
                    guarda_caracteres_roteiro += "N";
                }
                if (aleatorio_roteiro == 40)
                {
                    guarda_caracteres_roteiro += "O";
                }
                if (aleatorio_roteiro == 41)
                {
                    guarda_caracteres_roteiro += "P";
                }
                if (aleatorio_roteiro == 42)
                {
                    guarda_caracteres_roteiro += "Q";
                }
                if (aleatorio_roteiro == 43)
                {
                    guarda_caracteres_roteiro += "R";
                }
                if (aleatorio_roteiro == 44)
                {
                    guarda_caracteres_roteiro += "S";
                }
                if (aleatorio_roteiro == 45)
                {
                    guarda_caracteres_roteiro += "T";
                }
                if (aleatorio_roteiro == 46)
                {
                    guarda_caracteres_roteiro += "U";
                }
                if (aleatorio_roteiro == 47)
                {
                    guarda_caracteres_roteiro += "V";
                }
                if (aleatorio_roteiro == 48)
                {
                    guarda_caracteres_roteiro += "W";
                }
                if (aleatorio_roteiro == 49)
                {
                    guarda_caracteres_roteiro += "x";
                }
                if (aleatorio_roteiro == 50)
                {
                    guarda_caracteres_roteiro += "y";
                }
                if (aleatorio_roteiro == 51)
                {
                    guarda_caracteres_roteiro += "z";
                }
                if (aleatorio_roteiro == 52)
                {
                    guarda_caracteres_roteiro += "1";
                }
                if (aleatorio_roteiro == 53)
                {
                    guarda_caracteres_roteiro += "2";
                }
                if (aleatorio_roteiro == 54)
                {
                    guarda_caracteres_roteiro += "3";
                }
                if (aleatorio_roteiro == 55)
                {
                    guarda_caracteres_roteiro += "4";
                }
                if (aleatorio_roteiro == 56)
                {
                    guarda_caracteres_roteiro += "5";
                }
                if (aleatorio_roteiro == 57)
                {
                    guarda_caracteres_roteiro += "6";
                }
                if (aleatorio_roteiro == 58)
                {
                    guarda_caracteres_roteiro += "7";
                }
                if (aleatorio_roteiro == 59)
                {
                    guarda_caracteres_roteiro += "8";
                }
                if (aleatorio_roteiro == 60)
                {
                    guarda_caracteres_roteiro += "9";
                }
                if (aleatorio_roteiro == 61)
                {
                    guarda_caracteres_roteiro += "0";
                }
            }

            for (int vezes = 0; vezes <= codigos_roteiro.Count - 1; vezes++)
            {
                if (guarda_caracteres_roteiro == codigos_roteiro[vezes])
                {
                    guardar_codigo_roteiro = false;
                }
            }

            if (guardar_codigo_roteiro == true)
            {
                
                gameObject.GetComponentInChildren<Text>().text = guarda_caracteres_roteiro;
                guardou_roteiro = true;
            }

        }
    }
}