# 🦆 Simulador de Patos – Windows Forms com Áudio e Imagem (C#)

Simulador interativo de patos usando **Windows Forms em C#**, com navegação gráfica, sons, imagens dinâmicas e ações específicas para cada pato. Ideal para demonstrar **Programação Orientada a Objetos** na prática.

---

## 🎯 Funcionalidades

- Visualização dos patos com imagens
- Ações de nadar, voar e grasnar
- Sons personalizados ao **grasnar**
- Validação de ações conforme tipo do pato
- Troca dinâmica de imagens para cada ação
- Navegação entre os patos (anterior / próximo)
- Inclusão do pato especial `CyberDuck`

---

## 🧠 Conceitos de POO aplicados

| Conceito         | Aplicação                                                              |
|------------------|------------------------------------------------------------------------|
| **Herança**      | Todos os patos herdam da classe base `Duck`                           |
| **Interfaces**   | `IFlyable` e `IQuackable` definem comportamentos específicos           |
| **Polimorfismo** | `is IFlyable` permite ou não que o pato voe, sem saber o tipo exato    |
| **Encapsulamento** | Lógica de imagem/som isolada por método (`trocarFoto`, `carregarQuackSound`) |

---

## 🧩 Ações disponíveis no simulador

| Ação    | Comportamento                                  | Som? | Observação                                     |
|---------|------------------------------------------------|------|------------------------------------------------|
| `Nadar` | Troca imagem para `*Nadando.png`               | ❌   | Todos os patos nadam                          |
| `Voar`  | Troca imagem para `*Voando.png`                | ❌   | Apenas se implementar `IFlyable`, senão: som de falha |
| `Grasnar` | Reproduz `.wav` específico por pato           | ✅   | Som muda por tipo de pato                     |

---

## 🔉 Sons de Grasnar

Cada tipo de pato possui um arquivo `.wav` único para sua ação de `Grasnar()`:

| Pato         | Som                           | Arquivo               |
|--------------|--------------------------------|------------------------|
| MallardDuck  | Quack tradicional              | `MallardDuck.wav`     |
| RedHeadDuck  | Quack mais forte               | `RedHeadDuck.wav`     |
| RubberDuck   | Som de brinquedo/plástico      | `RubberDuck.wav`      |
| CyberDuck    | Grasno digital/futurista       | `CyberDuck.wav`       |
| Sem voo      | Reproduz som `fail.wav`        | ao tentar voar com pato que não voa |

---

🎓 Projeto desenvolvido como prática de **POO moderna com áudio, imagens e WinForms** por Mateus Botelho, Lucas Borges, Daniel Heringer e Victor Alves.

