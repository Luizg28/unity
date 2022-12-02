using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController
{
    public static bool cabeca;
    public static bool corpo;
    public static bool pe;
    public static bool andar;
    public static bool levantar;
    public static bool pular;

    public void reset(){
        RoboController.cabeca = false;
        RoboController.corpo = false;
        RoboController.pe = false;
        RoboController.andar = false;
        RoboController.levantar = false;
        RoboController.pular = false;
    }
}
