using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade = 5f;
    public float velocidadeCorrida = 9f;
    public float forcaPulo = 12f;

    [Header("Veraficação de Chão")]
    public Transform verificadorChao;
    public float raioChao = 0.2f;
    public LayerMask camadaChao;

    private Rigidbody2D rb;
    private bool noChao;
    private float movimentoHorizontal;
    private bool correndo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimentoHorizontal = Input.GetAxisRaw("Horizontal");

        correndo = Input.GetKey(KeyCode.LeftShift);

    if (Input.GetButtonDown("Jump"))
    {
        Debug.Log("Espaço pressionado. NoChao: " + noChao);
        if (noChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
            AudioManager.instancia.TocarSFX("pulo");
        }
    }

        if (movimentoHorizontal > 0)
            transform.localScale = new Vector3(1, 1, 1);

        else if (movimentoHorizontal < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    void FixedUpdate()
    {
        noChao = Physics2D.OverlapCircle(verificadorChao.position, 0.3f, camadaChao);
        Debug.Log("NoChao: " + noChao + " | Pos: " + verificadorChao.position);

        float vel = correndo ? velocidadeCorrida : velocidade;
        
        rb.linearVelocity = new Vector2(movimentoHorizontal * vel, rb.linearVelocity.y);
    }
    
}
