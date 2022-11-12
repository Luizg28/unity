using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DefinirParte : MonoBehaviour
{
    public Image caboriginal;
    public Sprite cabnewSprite1;
    public Sprite cabnewSprite2;
    public Sprite cabnewSprite3;
    public Sprite cabnewSprite4;
    public Image tororiginal;
    public Sprite tornewSprite1;
    public Sprite tornewSprite2;
    public Sprite tornewSprite3;
    public Sprite tornewSprite4;
    public Image peoriginal;
    public Sprite penewSprite1;
    public Sprite penewSprite2;
    public Sprite penewSprite3;
    public Sprite penewSprite4;
    public int cont;

    public GameObject drop;
    public GameObject drop2;
    public GameObject drop3;
    public GameObject testar;
    public int conte;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        conte = drop.GetComponent<Drop>().cont + drop2.GetComponent<Drop2>().cont + drop3.GetComponent<Drop3>().cont;
        cont = conte;
    }

    public void NewImage()
    {
        testar.SetActive(true);
        switch (cont)
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
        }
    }
}
