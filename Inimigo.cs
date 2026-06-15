using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade = 2f;
    public float distanciaPatrulha = 3f;

    private Vector2 posicaoInicial;
    private int direcao = 1;
    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direcao * velocidade * Time.deltaTime);

        float distancia = transform.position.x - posicaoInicial.x;

        if (distancia >= distanciaPatrulha)
            direcao = -1;
        else if (distancia <= -distanciaPatrulha)
            direcao = 1;

        transform.localScale = new Vector3(direcao, 1, 1);
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            GameManager.instancia.PerderVida();
        }
    }
}