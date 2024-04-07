using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    CharacterController controller;
    //----------------Movimenação esquerda, direita, frente  e tras ----------
    Vector3 foward; //EixoZ movimento pra frente e para trás
    Vector3 strafe; // eixoX movimento para a esquerda e ditereita
    Vector3 vertical;//eixoY movimento de pulo e gravidade

    public float fowardSpeed = 18f; // força
    public float strafeSpeed = 18f;
    //-------------------pulo --------------
    private int pulo = 0;
    float gravity; //força da gravidade
    float jumpSpeed; //velocidade do pulo
    public float maxJumpHeight = 5f;//altura max do pulo
    public float timeToMaxHeight = 0.3f; // tempo no ar do pulo

    //-----------------animação -------------
    private Animator anim;
    //---------------rotação
    public Vector3 Rotacao;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(Rotacao);
    
        anim = GetComponent<Animator>();
        //---------ocultar cursor do mouse----------
        Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
        //----------------------------
        controller = GetComponent<CharacterController>();
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / (timeToMaxHeight);
    }

    // Update is called once per frame
    void Update()
    {
        float fowardInput = Input.GetAxisRaw("Vertical"); //pega valor do S(-1) e W(1) 
        float strafeInput = Input.GetAxisRaw("Horizontal");//pega o valor de A(-1) e D(1) 


        // calculando a forca = input * velocidade * direção
        foward = fowardInput * fowardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;
        //--------pulo -----------

        vertical += gravity * Time.deltaTime * Vector3.up;

        if (controller.isGrounded){//se tiver em contado com o chão
            vertical = Vector3.down;//reseta a força da gravidade
            anim.SetInteger("transition",0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded ) { // quando aperta Space e está no chão(isGrounded), ele pula
            vertical = jumpSpeed * Vector3.up;
            anim.SetInteger("transition", 3);
           
        }
        
        Vector3 finalVelocity  = foward  + vertical+ strafe; // velocidade final somando todas as forças de atuação
        if (Input.GetKey(KeyCode.W) )
        {
            
            anim.SetInteger("transition", 1);
        }
        if (Input.GetKey(KeyCode.S) )
        {
            anim.SetInteger("transition", 4);
        }
        
        controller.Move(finalVelocity * Time.deltaTime);//Move move o personagem calculando a colisão com base na velocidade.

        //referencia: https://www.youtube.com/watch?v=_VUpFFVHZVQ&ab_channel=ProgramandoGames
    }
}
