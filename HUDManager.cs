using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public static HUDManager instancia;

    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoVidas;

    void Awake()
    {
        instancia = this;
    }

    public void AtualizarPontos(int pontos)
    {
        textoPontos.text = "Pontos: " + pontos;
    }

    public void AtualizarVidas(int vidas)
    {
        textoVidas.text = "Vidas: " + vidas;
    }
}