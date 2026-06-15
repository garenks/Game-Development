using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDeJogo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameManager.instancia.pontos = 0;
            GameManager.instancia.vidas = 3;
            SceneManager.LoadScene("Level1");
        }
    }
}