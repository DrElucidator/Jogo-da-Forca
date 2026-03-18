```markdown
# Jogo da Forca

Este repositório contém um simples **jogo da forca** desenvolvido em **C#** como um aplicativo de console.  
O objetivo do jogo é que o jogador tente descobrir uma palavra secreta (frutas brasileiras) antes que o boneco seja completado na forca.

---

## Funcionalidades

- **Seleção aleatória de palavras:** Lista de frutas brasileiras como palavras secretas.
- **Exibição da forca:** Desenho ASCII que evolui conforme os erros cometidos.
- **Validação de entrada:** Aceita letras individuais ou a palavra inteira.
- **Controle de vitória/derrota:** O jogo termina quando o jogador acerta a palavra ou ultrapassa o limite de erros.
- **Reinício do jogo:** Pergunta ao final de cada partida se o jogador deseja continuar.

---

## Regras do Jogo

1. O programa escolhe uma palavra secreta aleatória.
2. O jogador deve tentar adivinhar a palavra digitando letras ou a palavra completa.
3. Cada erro adiciona uma parte ao desenho da forca.
4. O jogador vence se descobrir todas as letras antes que o boneco seja completado.
5. O jogador perde se cometer mais de **6 erros**.
6. Ao final da rodada, é possível escolher se deseja jogar novamente.

---

## Estrutura do Projeto

- `Program.cs`: lógica principal do jogo.
- Funções auxiliares:
  - `RandomWordChoosen`: escolhe uma palavra aleatória.
  - `FillLetter`: inicializa os espaços da palavra com `_`.
  - `RunGame`: controla a lógica da partida.
  - `drawForca`: desenha a forca conforme os erros.
  - `Retry`: pergunta se o jogador deseja tentar mais uma rodada.

---

## Como Executar

1. Abra o terminal na pasta do projeto.
2. Compile o projeto com o comando:
   ```bash
   dotnet build
   ```
3. Execute o jogo:
   ```bash
   dotnet run
   ```

---

## Requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download).

---

## Objetivos de Aprendizado

- Praticar manipulação de strings e arrays.
- Implementar lógica condicional e loops.
- Trabalhar com entrada e saída no console.
- Aplicar conceitos de modularização e funções.
- Desenvolver um projeto completo para portfólio.

---

## Autor

Projeto desenvolvido por **Alec Luí** durante o curso da **Academia de Programadores**.  
Este repositório faz parte do meu portfólio no GitHub: [Jogo-da-Forca](https://github.com/DrElucidator/Jogo-da-Forca)

---

Obrigado por jogar!!
```