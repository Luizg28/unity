using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamarE : MonoBehaviour
{
    public GameObject botoes;
    public int co;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        co = botoes.GetComponent<Botoes>().cont;
    }
}
