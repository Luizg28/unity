using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController
{
    public static bool cabeca;
    public static bool corpo;
    public static bool pe;
    public static bool andarEsquerda;
    public static bool andarDireita;
    public static bool levantar;
    public static bool pular;
    public static bool feliz;
    public static bool irritado;
    public static bool indiferente;

    public void reset(){
        RoboController.cabeca = false;
        RoboController.corpo = false;
        RoboController.pe = false;
        RoboController.andarEsquerda = false;
        RoboController.andarDireita = false;
        RoboController.levantar = false;
        RoboController.pular = false;
        RoboController.feliz = false;
        RoboController.irritado = false;
        RoboController.indiferente = false;
    }
}
