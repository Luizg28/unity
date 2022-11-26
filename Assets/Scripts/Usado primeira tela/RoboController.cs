using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController
{
    public bool cabeca;
    public bool corpo;
    public bool pe;
    public bool andar;
    public bool levantar;
    public bool pular;

    public void reset(){
        this.cabeca = false;
        this.corpo = false;
        this.pe = false;
        this.andar = false;
        this.levantar = false;
        this.pular = false;
    }

    public string toString(){
        return "Cabeça: " + this.cabeca + "\nCorpo: " + this.corpo + "\nPé: " + this.pe;
    }
    
}
