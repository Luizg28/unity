using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController
{
    public bool cabeca;
    public bool corpo;
    public bool pe;

    public void reset(){
        this.cabeca = false;
        this.corpo = false;
        this.pe = false;
    }

    public string toString(){
        return "Cabeça: " + this.cabeca + "\nCorpo: " + this.corpo + "\nPé: " + this.pe;
    }
    
}
