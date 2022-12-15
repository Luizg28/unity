using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public GameObject player;

    public Sprite cabecaCorpo1;
    public Sprite cabecaPe1;
    public Sprite peCorpo1;
    public Sprite cabeca1;
    public Sprite corpo1;
    public Sprite inteiro2;
    public Sprite cabecaCorpo2;
    public Sprite cabecaPe2;
    public Sprite peCorpo2;
    public Sprite cabeca2;
    public Sprite corpo2;
    public Sprite inteiro3;
    public Sprite cabecaCorpo3;
    public Sprite cabecaPe3;
    public Sprite peCorpo3;
    public Sprite cabeca3;
    public Sprite corpo3;
    public Sprite pe;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (RoboController.indiferente)
        {
            if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
            {
                
            }

            else if (RoboController.cabeca && RoboController.corpo)
            {
                spriteRenderer.sprite = cabecaCorpo1;
            }

            else if (RoboController.cabeca && RoboController.pe)
            {
                spriteRenderer.sprite = cabecaPe1;
            }

            else if (RoboController.corpo && RoboController.pe)
            {
                spriteRenderer.sprite = peCorpo1;
            }

            else if (RoboController.cabeca)
            {
                spriteRenderer.sprite = cabeca1;
            }

            else if (RoboController.corpo)
            {
                spriteRenderer.sprite = corpo1;
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

        else if (RoboController.feliz)
        {
            if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
            {
                spriteRenderer.sprite = inteiro2;
            }

            else if (RoboController.cabeca && RoboController.corpo)
            {
                spriteRenderer.sprite = cabecaCorpo2;
            }

            else if (RoboController.cabeca && RoboController.pe)
            {
                spriteRenderer.sprite = cabecaPe2;
            }

            else if (RoboController.corpo && RoboController.pe)
            {
                spriteRenderer.sprite = peCorpo2;
            }

            else if (RoboController.cabeca)
            {
                spriteRenderer.sprite = cabeca2;
            }

            else if (RoboController.corpo)
            {
                spriteRenderer.sprite = corpo2;
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

        else if (RoboController.irritado)
        {
            if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
            {
                spriteRenderer.sprite = inteiro3;
            }

            else if (RoboController.cabeca && RoboController.corpo)
            {
                spriteRenderer.sprite = cabecaCorpo3;
            }

            else if (RoboController.cabeca && RoboController.pe)
            {
                spriteRenderer.sprite = cabecaPe3;
            }

            else if (RoboController.corpo && RoboController.pe)
            {
                spriteRenderer.sprite = peCorpo3;
            }

            else if (RoboController.cabeca)
            {
                spriteRenderer.sprite = cabeca3;
            }

            else if (RoboController.corpo)
            {
                spriteRenderer.sprite = corpo3;
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
        else
        {
            player.SetActive(false);
        }
    }


}
