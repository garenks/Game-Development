using UnityEngine;

public class Escalada : MonoBehaviour
{
    public float velocidadeEscalada = 3f;
    private bool naEscada = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (naEscada)
        {
            float vertical = Input.GetAxisRaw("Vertical");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, vertical * velocidadeEscalada);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 3;
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Escada"))
            naEscada = true;
    }

    void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.CompareTag("Escada"))
            naEscada = false;
    }
}