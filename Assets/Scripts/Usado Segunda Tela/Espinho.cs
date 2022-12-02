using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Espinho : MonoBehaviour
{       
    private SpriteRenderer sprite;
    private PolygonCollider2D polygon;
    string nomeDaCenaAtual;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        polygon = GetComponent<PolygonCollider2D>();
        nomeDaCenaAtual = SceneManager.GetActiveScene ().name;
    }
    //public GameObject touched;
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nomeDaCenaAtual);
        }
    }
}
