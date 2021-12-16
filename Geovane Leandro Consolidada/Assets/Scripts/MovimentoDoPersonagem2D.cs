using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoPersonagem2D : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] [Range(0, 200)] float velocidade = 8;
    [SerializeField] [Range(0, 50)] float ForcaDoPulo = 10;
    public Vector2 velocidadeFinal;
    Animator animacao;
    float inputHorizontal;
    bool pediuParaPular;
    bool estaNoAr;

    [SerializeField] LayerMask layerPiso;

    [SerializeField] Transform pontoInicialPiso;

    [SerializeField] Transform pontoFinalPiso;
    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        startPersonagem();
    }

    void Update()
    {
        CalculaVelocidade();
        LeInput();
    }

    private void FixedUpdate()
    {
        AplicaMovimento();
        EstaNoAr();
    }

    private void LateUpdate()
    {
        AplicaAnimacao();
    }
    void AplicaAnimacao()
    {
        animacao.SetFloat("EstaAndando", Mathf.Abs(velocidadeFinal.x));

        Debug.Log(Mathf.Abs(velocidadeFinal.x));

        animacao.SetBool("EstaNoAr", estaNoAr);
    }
    
    void startPersonagem()
    {
        rb = GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
    }

    void LeInput()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        pediuParaPular = Input.GetButton("Jump");
    }

    void EstaNoAr()
    {
        hit = Physics2D.Linecast(pontoInicialPiso.position, pontoFinalPiso.position, layerPiso);
        estaNoAr = hit.collider == null;
    }

    void CalculaVelocidade()
    {
        velocidadeFinal.x = inputHorizontal * velocidade;
        if (pediuParaPular)
        {
             velocidadeFinal.y = ForcaDoPulo;
        }
        else
        {
            velocidadeFinal.y = rb.velocity.y;
        }
    }

    void AplicaMovimento()
    {
        rb.velocity = velocidadeFinal;
    }
}
