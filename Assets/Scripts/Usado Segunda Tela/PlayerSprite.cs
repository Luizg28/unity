using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public GameObject player;

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
        }

        else if (RoboController.cabeca && RoboController.pe)
        {
            spriteRenderer.sprite = cabecaPe;
        }

        else if (RoboController.corpo && RoboController.pe)
        {
            spriteRenderer.sprite = peCorpo;
        }

        else if (RoboController.cabeca)
        {
            spriteRenderer.sprite = cabeca;
        }

        else if (RoboController.corpo)
        {
            spriteRenderer.sprite = corpo;
        }

        else if (RoboController.pe)
        {
            spriteRenderer.sprite = pe;
        }

        else
        {
            player.SetActive(false);
        }
    }


}
