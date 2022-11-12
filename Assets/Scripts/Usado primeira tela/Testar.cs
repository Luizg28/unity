using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testar : MonoBehaviour
{
    public GameObject Cod1;
    public GameObject Cod2;
    public GameObject Cod3;
    public GameObject Cai1;
    public GameObject Cai2;
    public GameObject Cai3;
    public GameObject Bot1;
    public GameObject Bot2;
    public GameObject Bot3;
    public GameObject Bot4;
    public GameObject Tela;
    public GameObject Grid;
    public GameObject Cab;
    public GameObject Corp;
    public GameObject Pe;

    public void test()
    {
        Cod1.SetActive(false);
        Cod2.SetActive(false);
        Cod3.SetActive(false);
        Bot1.SetActive(false);
        Bot2.SetActive(false);
        Bot3.SetActive(false);
        Bot4.SetActive(false);
        Tela.SetActive(false);
        Cai1.SetActive(false);
        Cai2.SetActive(false);
        Cai3.SetActive(false);
        Grid.SetActive(true);
        Cab.transform.position = new Vector3(-14, 211, 0f);
        Corp.transform.position = new Vector3(-14, 111, 0f);
        Pe.transform.position = new Vector3(-14, 111, 0f);
    }
}
