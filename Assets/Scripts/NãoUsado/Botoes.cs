using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    public Image original;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public int cont;

    public GameObject botoese;
    public int conte;

    void Start()
    {
        
    }

    
    void Update()
    {
        conte = botoese.GetComponent<BotoesE>().cont;
        cont = conte;
    }

    public void NewImage()
    {
        switch (cont)
        {
        case 0:
            original.sprite = newSprite1;
            cont = 1;
            conte = cont;
        break;

        case 1:
            original.sprite = newSprite2;
            cont = 2;
            conte = cont;
        break;

        case 2:
            original.sprite = newSprite3;
            cont = 3;
            conte = cont;
        break;
        
        case 3:
            original.sprite = newSprite4;
            cont = 0;
            conte = cont;
        break;

        default:
        break;
        }
    }
}
