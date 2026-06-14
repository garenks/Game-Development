# Circuit Rush 🤖⚡

> Jogo de plataforma 2D desenvolvido na Unity como projeto final da disciplina de Game Development — UniFECAF.

---

## Sobre o Jogo

Circuit Rush é um jogo de ação e plataforma 2D onde você controla um robô que escapou de uma fábrica abandonada e precisa atravessar circuitos elétricos corrompidos para alcançar a saída.

Atravesse 3 fases com dificuldade crescente, colete moedas, desvie de inimigos e chegue ao portal de saída!

---

## Controles

| Ação | Tecla |
|------|-------|
| Mover | `A` / `D` ou `←` / `→` |
| Correr | `Shift` (segure enquanto move) |
| Pular | `Espaço` |
| Escalar | `W` / `S` (próximo à escada) |
| Reiniciar (Game Over) | `R` |

---

## Fases

### Fase 1 — Introdução
- Ambiente plano com chão contínuo
- 1 inimigo de patrulha
- 3 moedas acessíveis
- Escada introdutória
- Objetivo: aprender os controles básicos

### Fase 2 — Plataformas
- 3 plataformas suspensas em alturas variadas
- 2 inimigos (um no chão, um nas plataformas)
- 3 moedas distribuídas verticalmente
- Objetivo: dominar o pulo e movimentação vertical

### Fase 3 — Desafio
- 4 plataformas em alturas variadas
- 3 inimigos com velocidade aumentada
- 4 moedas em posições desafiadoras
- Portal na plataforma mais alta
- Objetivo: usar todas as mecânicas em conjunto

---

## ⚙️ Mecânicas Implementadas

- ✅ Andar, correr, pular, escalar
- ✅ Sistema de vidas (3 vidas)
- ✅ Sistema de pontuação (10 pts por moeda)
- ✅ HUD com pontuação e vidas em tempo real
- ✅ Inimigos com patrulha automática
- ✅ Coletáveis com feedback visual e sonoro
- ✅ Portal de transição entre fases
- ✅ Tela de Game Over com opção de reiniciar
- ✅ Tela de vitória ao completar as 3 fases
- ✅ Trilha sonora + efeitos sonoros chiptune
- ✅ Câmera que segue o jogador

---

## 🛠️ Tecnologias Utilizadas

- **Engine:** Unity 6.4 (6000.4.11f1)
- **Linguagem:** C#
- **Física:** Unity Physics 2D (Rigidbody2D)
- **UI:** Unity UI + TextMeshPro
- **Áudio:** Unity Audio System

---

## 📁 Estrutura do Projeto

```
Assets/
├── Scripts/
│   ├── PlayerController.cs   # Movimento do personagem
│   ├── Escalada.cs           # Mecânica de escalada
│   ├── Inimigo.cs            # Patrulha dos inimigos
│   ├── Coletavel.cs          # Sistema de coleta
│   ├── Portal.cs             # Transição de fases
│   ├── GameManager.cs        # Gerenciamento geral do jogo
│   ├── AudioManager.cs       # Sistema de áudio
│   ├── HUDManager.cs         # Interface do jogador
│   ├── CameraFollow.cs       # Câmera que segue o player
│   ├── TelaGameOver.cs       # Lógica da tela de Game Over
│   └── FimDeJogo.cs          # Lógica da tela de vitória
├── Sprites/                  # Assets visuais
├── Animations/               # Animações
├── Audio/
│   ├── Music/                # Trilhas sonoras
│   └── SFX/                  # Efeitos sonoros
├── Prefabs/                  # Objetos reutilizáveis
├── Scenes/
│   ├── Level1.unity
│   ├── Level2.unity
│   ├── Level3.unity
│   ├── GameOver.unity
│   └── FimDeJogo.unity
└── Fonts/
```

---

## 🎵 Créditos de Áudio

- **Pack:** Hungry Dino (9 trilhas chiptune + 10 SFX)
- **Autor:** SketchyLogic
- **Fonte:** https://opengameart.org/users/sketchylogic
- **Licença:** CC-BY 3.0 — uso livre com crédito ao autor

---

## 🚀 Como Executar

### Pelo executável:
1. Baixe a pasta `CircuitRush_Build`
2. Execute o arquivo `CircuitRush.exe` (Windows)

### Pelo Unity Editor:
1. Clone o repositório
2. Abra o Unity Hub e clique em **Add Project**
3. Selecione a pasta do projeto
4. Abra a cena `Scenes/Level1`
5. Pressione **Play**

---

## 👤 Autor

**Paulo Vitor(Opfer)**  
Análise e Desenvolvimento de Sistemas — UniFECAF  
GitHub: [@garenks](https://github.com/garenks)

---

*Projeto desenvolvido para a disciplina de Game Development — 2026*
