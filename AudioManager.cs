using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instancia;

    public AudioSource musicaSource;
    public AudioSource sfxSource;

    public AudioClip musicaFase;
    public AudioClip sfxPulo;
    public AudioClip sfxColetar;
    public AudioClip sfxDano;
    public AudioClip sfxMorte;

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

    void Start()
    {
        if (musicaFase != null)
        {
            musicaSource.clip = musicaFase;
            musicaSource.loop = true;
            musicaSource.Play();
        }
    }

    public void TocarSFX(string nome)
    {
        AudioClip clip = null;

        switch (nome)
        {
            case "pulo": clip = sfxPulo; break;
            case "coletar": clip = sfxColetar; break;
            case "dano": clip = sfxDano; break;
            case "morte": clip = sfxMorte; break;
        }

        if (clip != null)
            sfxSource.PlayOneShot(clip);
    }
}