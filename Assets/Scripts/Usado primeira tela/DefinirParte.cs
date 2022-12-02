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

    //public RoboController robo;
    
    void Start()
    {
        //robo = new RoboController();
    }

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
            case "andar":
                RoboController.andar = true;
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

        /*switch (cont)
        {
        case 1:
            System.Random rnd1 = new System.Random();
            int r1 = rnd1.Next(0,5);
            switch (r1)
            {
                case 1:
                    caboriginal.sprite = cabnewSprite1;
                break;
                
                case 2:
                    caboriginal.sprite = cabnewSprite2;
                break;

                case 3:
                    caboriginal.sprite = cabnewSprite3;
                break;

                case 4:
                    caboriginal.sprite = cabnewSprite4;
                break;

                default:
                break;
            }
        break;

        case 2:
            System.Random rnd2 = new System.Random();
            int r2 = rnd2.Next(0,5);
            switch (r2)
            {
                case 1:
                    tororiginal.sprite = tornewSprite1;
                break;
                
                case 2:
                    tororiginal.sprite = tornewSprite2;
                break;

                case 3:
                    tororiginal.sprite = tornewSprite3;
                break;

                case 4:
                    tororiginal.sprite = tornewSprite4;
                break;

                default:
                break;
            }
        break;

        case 4:
            System.Random rnd4 = new System.Random();
            int r4 = rnd4.Next(0,5);
            switch (r4)
            {
                case 1:
                    peoriginal.sprite = penewSprite1;
                break;
                
                case 2:
                    peoriginal.sprite = penewSprite2;
                break;

                case 3:
                    peoriginal.sprite = penewSprite3;
                break;

                case 4:
                    peoriginal.sprite = penewSprite4;
                break;

                default:
                break;
            }
        break;

        case 3:
            System.Random rnd12 = new System.Random();
            int r12 = rnd12.Next(0,5);
            switch (r12)
            {
                case 1:
                    caboriginal.sprite = cabnewSprite1;
                break;
                
                case 2:
                    caboriginal.sprite = cabnewSprite2;
                break;

                case 3:
                    caboriginal.sprite = cabnewSprite3;
                break;

                case 4:
                    caboriginal.sprite = cabnewSprite4;
                break;

                default:
                break;
            }
            System.Random rnd21 = new System.Random();
            int r21 = rnd21.Next(0,5);
            switch (r21)
            {
                case 1:
                    tororiginal.sprite = tornewSprite1;
                break;
                
                case 2:
                    tororiginal.sprite = tornewSprite2;
                break;

                case 3:
                    tororiginal.sprite = tornewSprite3;
                break;

                case 4:
                    tororiginal.sprite = tornewSprite4;
                break;

                default:
                break;
            }
        break;

        case 5:
            System.Random rnd14 = new System.Random();
            int r14 = rnd14.Next(0,5);
            switch (r14)
            {
                case 1:
                    caboriginal.sprite = cabnewSprite1;
                break;
                
                case 2:
                    caboriginal.sprite = cabnewSprite2;
                break;

                case 3:
                    caboriginal.sprite = cabnewSprite3;
                break;

                case 4:
                    caboriginal.sprite = cabnewSprite4;
                break;

                default:
                break;
            }
            System.Random rnd41 = new System.Random();
            int r41 = rnd41.Next(0,5);
            switch (r41)
            {
                case 1:
                    peoriginal.sprite = penewSprite1;
                break;
                
                case 2:
                    peoriginal.sprite = penewSprite2;
                break;

                case 3:
                    peoriginal.sprite = penewSprite3;
                break;

                case 4:
                    peoriginal.sprite = penewSprite4;
                break;

                default:
                break;
            }
        break;

        case 6:
            System.Random rnd24 = new System.Random();
            int r24 = rnd24.Next(0,5);
            switch (r24)
            {
                case 1:
                    tororiginal.sprite = tornewSprite1;
                break;
                
                case 2:
                    tororiginal.sprite = tornewSprite2;
                break;

                case 3:
                    tororiginal.sprite = tornewSprite3;
                break;

                case 4:
                    tororiginal.sprite = tornewSprite4;
                break;

                default:
                break;
            }
            System.Random rnd42 = new System.Random();
            int r42 = rnd42.Next(0,5);
            switch (r42)
            {
                case 1:
                    peoriginal.sprite = penewSprite1;
                break;
                
                case 2:
                    peoriginal.sprite = penewSprite2;
                break;

                case 3:
                    peoriginal.sprite = penewSprite3;
                break;

                case 4:
                    peoriginal.sprite = penewSprite4;
                break;

                default:
                break;
            }
        break;

        case 7:
            System.Random rnd124 = new System.Random();
            int r124 = rnd124.Next(0,5);
            switch (r124)
            {
                case 1:
                    caboriginal.sprite = cabnewSprite1;
                break;
                
                case 2:
                    caboriginal.sprite = cabnewSprite2;
                break;

                case 3:
                    caboriginal.sprite = cabnewSprite3;
                break;

                case 4:
                    caboriginal.sprite = cabnewSprite4;
                break;

                default:
                break;
            }
            System.Random rnd241 = new System.Random();
            int r241 = rnd241.Next(0,5);
            switch (r241)
            {
                case 1:
                    tororiginal.sprite = tornewSprite1;
                break;
                
                case 2:
                    tororiginal.sprite = tornewSprite2;
                break;

                case 3:
                    tororiginal.sprite = tornewSprite3;
                break;

                case 4:
                    tororiginal.sprite = tornewSprite4;
                break;

                default:
                break;
            }
            System.Random rnd412 = new System.Random();
            int r412 = rnd412.Next(0,5);
            switch (r412)
            {
                case 1:
                    peoriginal.sprite = penewSprite1;
                break;
                
                case 2:
                    peoriginal.sprite = penewSprite2;
                break;

                case 3:
                    peoriginal.sprite = penewSprite3;
                break;

                case 4:
                    peoriginal.sprite = penewSprite4;
                break;

                default:
                break;
            }
        break;

        default:
        break;
        }*/
    }
}
