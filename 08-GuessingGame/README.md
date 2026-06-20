# 🎯 Jogo de Adivinhação em C#

Projeto simples desenvolvido em **C#** que implementa um jogo de adivinhação no terminal.

O programa escolhe aleatoriamente um número entre **0 e 9**, e o jogador deve tentar descobri-lo. A cada tentativa, o sistema informa se o valor informado foi muito alto, muito baixo ou se o jogador acertou.

---

## 📌 Descrição

O jogo gera um número aleatório utilizando:

```csharp
Random.Shared.Next(10)
```

O jogador pode realizar quantas tentativas forem necessárias até acertar.

Após cada chute, o método `VerificarChute()` compara o valor informado com a resposta e exibe uma mensagem apropriada:

* **Muito alto** → quando o chute é maior que a resposta;
* **Muito baixo** → quando o chute é menor que a resposta;
* **Parabéns, você acertou!** → quando o chute é igual à resposta.

Além disso, o programa informa o número total de tentativas realizadas.

---

## 🎯 Conceitos Praticados

* Métodos
* Estruturas condicionais (`if`, `else if`, `else`)
* Estruturas de repetição (`while`)
* Geração de números aleatórios
* Entrada e saída de dados no console
* Conversão de tipos (`Convert.ToInt32`)
* Controle de fluxo
* Uso de `Thread.Sleep()` e `Console.Clear()`

---

## ▶️ Como Executar

### Pré-requisitos

* .NET SDK 6.0 ou superior

Verifique a instalação:

```bash
dotnet --version
```

### Executando o projeto

Clone o repositório:

```bash
git clone https://github.com/andreeliasgv/csharp-lab.git
```

Entre na pasta:

```bash
cd csharp-lab/GuessingGame
```

Execute:

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Primeira tentativa

```text
===========================================
==========  Jogo de Adivinhação  ==========
===========================================

Tentativa n°1

Um número foi selecionado. Qual é o seu chute?
Digite um número para continuar:
> 8

Muito alto, tente novamente!
```

### Segunda tentativa

```text
Tentativa n°2

Um número foi selecionado. Qual é o seu chute?
Digite um número para continuar:
> 3

Muito baixo, tente novamente!
```

### Acertando

```text
Parabéns, você acertou!

Resposta = 5
Tentativas = 3
```

---

## 📂 Estrutura do Projeto

```text
GuessingGame/
│
├── Program.cs
└── GuessingGame.csproj
```

---

## ⚙️ Funcionamento

1. O programa gera um número aleatório entre **0 e 9**.
2. O jogador informa um palpite.
3. O método `VerificarChute()` compara o chute com a resposta:

   * Se for maior, informa que o valor está muito alto;
   * Se for menor, informa que o valor está muito baixo;
   * Se for igual, o jogador vence.
4. O contador de tentativas é incrementado a cada rodada.
5. O jogo continua até que o número seja descoberto.

---

## 📚 Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 🎓 Objetivo do Projeto

Este projeto possui finalidade **educacional** e foi desenvolvido para praticar:

* Criação e chamada de métodos;
* Estruturas condicionais;
* Estruturas de repetição;
* Manipulação de números aleatórios;
* Controle de fluxo em aplicações de console;
* Desenvolvimento de aplicações em C#.

---

✍️ Desenvolvido como exercício prático de programação em C#.
