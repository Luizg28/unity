using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeclado : MonoBehaviour
{   
    public float Speed;
    public float JumpForce;

    public bool isJumping;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    public void Move()
    {
        if(RoboController.andarDireita && RoboController.andarEsquerda && RoboController.pe)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * Speed;
        }
        else if (RoboController.andarDireita && RoboController.pe)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * Speed;
        }
        else if (RoboController.andarEsquerda && RoboController.pe)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * Speed;
        }
    }

    public void Jump()
    {
        if (RoboController.pular && RoboController.pe)
        {
            if(Input.GetButtonDown("Jump"))
            {
                if(!isJumping)
                {
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                }  
            }
        }
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
