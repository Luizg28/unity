using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarTela : MonoBehaviour
{
    public void carregarTela(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}
