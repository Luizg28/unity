using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotoesE : MonoBehaviour
{
    public Image original;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public int cont;

    public GameObject botoes;
    public int contd;

    void Start()
    {
        
    }

    
    void Update()
    {
        contd = botoes.GetComponent<Botoes>().cont;
        cont = contd;
    }

    public void NewImage()
    {
        switch (cont)
        {
        case 0:
            original.sprite = newSprite1;
            cont = 3;
            contd = cont;
        break;

        case 3:
            original.sprite = newSprite2;
            cont = 2;
            contd = cont;
        break;

        case 2:
            original.sprite = newSprite3;
            cont = 1;
            contd = cont;
        break;

        case 1:
            original.sprite = newSprite4;
            cont = 0;
            contd = cont;
        break;

        default:
        break;
        }
    }
}
