using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int valor = 10;
    public string tipoColetavel = "moeda";

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            GameManager.instancia.AdicionarPontos(valor);
            AudioManager.instancia.TocarSFX("coletar");
            Destroy(gameObject);
        }
    }
}