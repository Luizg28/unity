using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Numeros : MonoBehaviour
{
    public int resul;
    
    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();

        for (int j = 0; j < 3; j++)
        {
            resul = rnd.Next(4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pedido()
    {
        System.Random rnd = new System.Random();

        for (int j = 0; j < 3; j++)
        {
            resul = rnd.Next(4);
        }
    }
}
