using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoPersonagem2D : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] [Range(0, 200)] float velocidade = 8;
    [SerializeField] [Range(0, 50)] float ForcaDoPulo = 10;
    Vector2 velocidadeFinal;
    float inputHorizontal;
    bool pediuParaPular;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        CalculaVelocidade();
        LeInput();
    }

    private void FixedUpdate()
    {
        AplicaMovimento();
    }

    private void LateUpdate()
    {
        AplicaAnimacao();
    }
    void AplicaAnimacao()
    {

    }

    void LeInput()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        pediuParaPular = Input.GetButton("Jump");
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
