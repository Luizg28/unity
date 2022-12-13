using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public GameObject player;
    public GameObject avisoPular;
    public GameObject avisoAndarDireita;
    public GameObject avisoAndarEsquerda;
    public GameObject avisoLevantarBraco;

    public Sprite cabecaCorpo;
    public Sprite cabecaPe;
    public Sprite peCorpo;
    public Sprite cabeca;
    public Sprite corpo;
    public Sprite pe;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (RoboController.cabeca && RoboController.corpo)
        {
            spriteRenderer.sprite = cabecaCorpo;
            avisoAndarDireita.SetActive(true);
            avisoAndarEsquerda.SetActive(true);
        }

        else if (RoboController.cabeca && RoboController.pe)
        {
            spriteRenderer.sprite = cabecaPe;
            avisoLevantarBraco.SetActive(true);
        }

        else if (RoboController.corpo && RoboController.pe)
        {
            spriteRenderer.sprite = peCorpo;
        }

        else if (RoboController.cabeca)
        {
            spriteRenderer.sprite = cabeca;
            avisoLevantarBraco.SetActive(true);
            avisoAndarDireita.SetActive(true);
            avisoAndarEsquerda.SetActive(true);
        }

        else if (RoboController.corpo)
        {
            spriteRenderer.sprite = corpo;
            avisoAndarDireita.SetActive(true);
            avisoAndarEsquerda.SetActive(true);
        }

        else if (RoboController.pe)
        {
            spriteRenderer.sprite = pe;
            avisoLevantarBraco.SetActive(true);
        }

        else
        {
            player.SetActive(false);
        }
    }


}
