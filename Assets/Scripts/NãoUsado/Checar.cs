using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checar : MonoBehaviour
{
    public Image original;
    public Sprite newSprite1;
    public Sprite newSprite2;

    public GameObject botoesC;
    public GameObject botoesT;
    public GameObject botoesP;

    public int vc;
    public int vt;
    public int vp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vc = botoesC.GetComponent<Botoes>().cont;
        vt = botoesT.GetComponent<Botoes>().cont;
        vp = botoesP.GetComponent<Botoes>().cont;
    }

    public void Resultado(){

        if(vc == 0)
        {
            original.sprite = newSprite1;
        }
        else
        {
            original.sprite = newSprite2;
        }
    }
}
