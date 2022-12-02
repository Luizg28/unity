using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject botaoPulo;
    public GameObject botaoAndar;
    public GameObject botaoLevantarBraco;
    //public GameObject botaoPuloDuplo;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite newSprite2;

    private bool moveLeft;
    private bool moveRight;
    private bool moveJump;
    private bool moveDoubleJump;
    private bool moveLevantar;

    public bool isJumping;
    public bool doubleJump;

    private float horizontalMove;

    public float jumpForce;
    public float speed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        moveLeft = false;
        moveRight = false;

        
        if (RoboController.andar && RoboController.pular && RoboController.levantar)
        {
            botaoAndar.SetActive(true);
            botaoPulo.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular && RoboController.levantar)
        {
            botaoPulo.SetActive(true);
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular && RoboController.andar)
        {
            botaoPulo.SetActive(true);
            botaoAndar.SetActive(true);
        }

        else if(RoboController.levantar && RoboController.andar)
        {
            botaoLevantarBraco.SetActive(true);
            botaoAndar.SetActive(true);
        }

        else if(RoboController.levantar)
        {
            botaoLevantarBraco.SetActive(true);
        }

        else if(RoboController.pular)
        {
            botaoPulo.SetActive(true);
        }

        else if(RoboController.andar)
        {
            botaoAndar.SetActive(true);
        }
        
    }

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

    public void PointerUpLeva()
    {
        moveLevantar = false;
        this.spriteRenderer.sprite = newSprite;
    }

    void Update()
    {
        MovementPlayer();
    }

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
                doubleJump = true;
            }
            else
            {
                if(doubleJump)
                {
                    jumpForce = 1;
                    rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
        }

        else if(moveLevantar)
        {
            spriteRenderer.sprite = newSprite;
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