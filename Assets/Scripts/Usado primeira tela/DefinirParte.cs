using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DefinirParte : MonoBehaviour
{
    public Image cabecaOriginal;
    public Sprite novaCabeca;
    public Image corpoOriginal;
    public Sprite novoCorpo;
    public Image peOriginal;
    public Sprite novoPe;

    public GameObject caixaCod1;
    public GameObject caixaCod2;
    public GameObject caixaCod3;
    public GameObject caixaCod4;
    public GameObject caixaCod5;
    public GameObject caixaCod6;
    public GameObject caixaCod7;

    private void verificaComponente(string componentName){
        switch(componentName){
            case "cabeca":
                RoboController.cabeca = true;
                cabecaOriginal.sprite = novaCabeca;
                break;
            case "corpo":
                RoboController.corpo = true;
                corpoOriginal.sprite = novoCorpo;
                break;
            case "pe":
                RoboController.pe = true;
                peOriginal.sprite = novoPe;
                break;
            case "andarDireita":
                RoboController.andarDireita = true;
                break;
            case "andarEsquerda":
                RoboController.andarEsquerda = true;
                break;
            case "levantar":
                RoboController.levantar = true;
                break;
            case "pular":
                RoboController.pular = true;
                break;
            default:
                break;
        }
    }

    public void NewRobo()
    {
        verificaComponente(caixaCod1.GetComponent<Drop>().componentName);
        verificaComponente(caixaCod2.GetComponent<Drop>().componentName);
        verificaComponente(caixaCod3.GetComponent<Drop>().componentName);
        verificaComponente(caixaCod4.GetComponent<Drop>().componentName);
        verificaComponente(caixaCod5.GetComponent<Drop>().componentName);
        verificaComponente(caixaCod6.GetComponent<Drop>().componentName);
        verificaComponente(caixaCod7.GetComponent<Drop>().componentName);
    }
}
