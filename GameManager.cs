using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public int pontos = 0;
    public int vidas = 3;
    public int faseAtual = 1;
    public int totalFases = 3;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AdicionarPontos(int valor)
    {
        pontos += valor;
        HUDManager.instancia.AtualizarPontos(pontos);
    }

    public void PerderVida()
    {
        vidas--;
        HUDManager.instancia.AtualizarVidas(vidas);
        AudioManager.instancia.TocarSFX("dano");

        if (vidas <= 0)
            GameOver();
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ProximaFase()
    {
        faseAtual++;
        if (faseAtual > totalFases)
            SceneManager.LoadScene("FimDeJogo");
        else
            SceneManager.LoadScene("Level" + faseAtual);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}