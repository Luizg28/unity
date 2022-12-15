using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    //rigibody é necessário para a movimentação
    private Rigidbody2D rb;

    //objetos de jogo que serão utilizados
    public GameObject botaoPulo;
    public GameObject botaoAndarDireita;
    public GameObject botaoAndarEsquerda;
    public GameObject botaoLevantarBraco;
    public GameObject avisoPular;
    public GameObject avisoAndarDireita;
    public GameObject avisoAndarEsquerda;
    public GameObject avisoLevantarBraco;

    //sprites que serão alterados pelo levantar braço
    public SpriteRenderer spriteRenderer;
    public Sprite inteirolevantabraco1;
    public Sprite inteirolevantabraco2;
    public Sprite inteirolevantabraco3;
    public Sprite cabecacorpolevantabraco1;
    public Sprite cabecacorpolevantabraco2;
    public Sprite cabecacorpolevantabraco3;
    public Sprite corpopelevantabraco1;
    public Sprite corpopelevantabraco2;
    public Sprite corpopelevantabraco3;
    public Sprite corpolevantabraco1;
    public Sprite corpolevantabraco2;
    public Sprite corpolevantabraco3;
    public Sprite inteiro1;
    public Sprite inteiro2;
    public Sprite inteiro3;
    public Sprite cabecacorpo1;
    public Sprite cabecacorpo2;
    public Sprite cabecacorpo3;
    public Sprite corpope1;
    public Sprite corpope2;
    public Sprite corpope3;
    public Sprite corpo1;
    public Sprite corpo2;
    public Sprite corpo3;

    //variaveis para movimentar o personagem
    private bool moveLeft;
    private bool moveRight;
    private bool moveJump;
    private bool moveDoubleJump;
    private bool moveLevantar;

    public bool isJumping;

    private float horizontalMove;

    public float jumpForce;
    public float speed = 5;

    //quando iniciar cena de execução o código ira ver o que foi adicionado na cena de criação apartir deste start
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        moveLeft = false;
        moveRight = false;

        if (RoboController.andarDireita && RoboController.andarEsquerda && RoboController.pular && RoboController.levantar)
        {
            botaoAndarDireita.SetActive(true);
            botaoAndarEsquerda.SetActive(true);
            botaoPulo.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular && RoboController.levantar && RoboController.andarDireita)
        {
            botaoAndarDireita.SetActive(true);
            botaoPulo.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular && RoboController.levantar && RoboController.andarEsquerda)
        {
            botaoAndarEsquerda.SetActive(true);
            botaoPulo.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular && RoboController.andarDireita && RoboController.andarEsquerda)
        {
            botaoAndarEsquerda.SetActive(true);
            botaoAndarDireita.SetActive(true);
            botaoPulo.SetActive(true);
        }

        else if(RoboController.levantar && RoboController.andarDireita && RoboController.andarEsquerda)
        {
            botaoAndarEsquerda.SetActive(true);
            botaoAndarDireita.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular && RoboController.andarDireita)
        {
            botaoPulo.SetActive(true);
            botaoAndarDireita.SetActive(true);
        }

        else if(RoboController.pular && RoboController.andarEsquerda)
        {
            botaoPulo.SetActive(true);
            botaoAndarEsquerda.SetActive(true);
        }

        else if(RoboController.levantar && RoboController.andarDireita)
        {
            botaoLevantarBraco.SetActive(true);
            botaoAndarDireita.SetActive(true);
        }

        else if(RoboController.levantar && RoboController.andarEsquerda)
        {
            botaoAndarEsquerda.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.levantar && RoboController.andarDireita)
        {
            botaoAndarDireita.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.andarDireita && RoboController.andarEsquerda)
        {
            botaoAndarEsquerda.SetActive(true);
            botaoAndarDireita.SetActive(true);
        }

        else if(RoboController.levantar && RoboController.pular)
        {
            botaoPulo.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.levantar)
        {
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular)
        {
            botaoPulo.SetActive(true);
        }

        else if(RoboController.andarDireita)
        {
            botaoAndarDireita.SetActive(true);
        }

        else if(RoboController.andarEsquerda)
        {
            botaoAndarEsquerda.SetActive(true);
        }
        
    }

    //movimentação do personagem
    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false;
    }

    public void PointerDownJump()
    {
        moveJump = true;
    }

    public void PointerUpJump()
    {
        moveJump = false;
    }

    public void PointerDownLeva()
    {
        moveLevantar = true;
    }

    //aqui é necessário que sempre que o botão levantar braço deixe de ser clicado o sprite normal apareça
    public void PointerUpLeva()
    {
        moveLevantar = false;
        if(RoboController.indiferente)
            {
                if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = inteiro1;
                }

                else if (RoboController.cabeca && RoboController.corpo)
                {
                    spriteRenderer.sprite = cabecacorpo1;
                }

                else if (RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = corpope1;
                }

                else if (RoboController.corpo)
                {
                    spriteRenderer.sprite = corpo1;
                }
            }
            else if(RoboController.feliz)
            {
                if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = inteiro2;
                }

                else if (RoboController.cabeca && RoboController.corpo)
                {
                    spriteRenderer.sprite = cabecacorpo2;
                }

                else if (RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = corpope2;
                }

                else if (RoboController.corpo)
                {
                    spriteRenderer.sprite = corpo2;
                }
            }
            else if(RoboController.irritado)
            {
                if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = inteiro3;
                }

                else if (RoboController.cabeca && RoboController.corpo)
                {
                    spriteRenderer.sprite = cabecacorpo3;
                }

                else if (RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = corpope3;
                }

                else if (RoboController.corpo)
                {
                    spriteRenderer.sprite = corpo3;
                }
            }
    }

    //atulizando sobre a movimentação do jogador
    void Update()
    {
        MovementPlayer();
    }

    //responsável por executar a movimentação do jogador
    private void MovementPlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
        }

        else if (moveRight)
        {
            horizontalMove = speed;
        }

        else if (moveJump)
        {
            if(!isJumping)
            {
                jumpForce = 1;
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            }
        }

        else if(moveLevantar)
        {
            if(RoboController.indiferente)
            {
                if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = inteirolevantabraco1;
                }

                else if (RoboController.cabeca && RoboController.corpo)
                {
                    spriteRenderer.sprite = cabecacorpolevantabraco1;
                }

                else if (RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = corpopelevantabraco1;
                }

                else if (RoboController.corpo)
                {
                    spriteRenderer.sprite = corpolevantabraco1;
                }
            }
            else if(RoboController.feliz)
            {
                if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = inteirolevantabraco2;
                }

                else if (RoboController.cabeca && RoboController.corpo)
                {
                    spriteRenderer.sprite = cabecacorpolevantabraco2;
                }

                else if (RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = corpopelevantabraco2;
                }

                else if (RoboController.corpo)
                {
                    spriteRenderer.sprite = corpolevantabraco2;
                }
            }
            else if(RoboController.irritado)
            {
                if (RoboController.cabeca && RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = inteirolevantabraco3;
                }

                else if (RoboController.cabeca && RoboController.corpo)
                {
                    spriteRenderer.sprite = cabecacorpolevantabraco3;
                }

                else if (RoboController.corpo && RoboController.pe)
                {
                    spriteRenderer.sprite = corpopelevantabraco3;
                }

                else if (RoboController.corpo)
                {
                    spriteRenderer.sprite = corpolevantabraco3;
                }
            }
        }

        else
        {
            horizontalMove = 0;
            jumpForce = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    //responsável por avisar se pode ou não pular
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }
}