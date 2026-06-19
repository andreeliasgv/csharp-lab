# 🧮 Calculadora Simples em C#

Projeto desenvolvido em **C#** para execução no terminal, com o objetivo de praticar conceitos básicos da linguagem, como:

- Variáveis
- Conversão de tipos
- Estruturas condicionais (`switch`)
- Operadores aritméticos
- Entrada e saída de dados pelo console

---

## 📌 Descrição

A aplicação solicita ao usuário:

1. O primeiro número.
2. A operação matemática desejada.
3. O segundo número.

Após a entrada dos dados, o programa realiza o cálculo e exibe o resultado na tela.

### Tratamento de Erro
O programa inclui um tratamento básico para divisão por zero, exibindo uma mensagem de erro caso o usuário tente dividir um número por zero.

### Operações disponíveis

| Código | Operação |
|-------:|----------|
| 1 | Adição |
| 2 | Subtração |
| 3 | Multiplicação |
| 4 | Divisão |

---

## 🏗️ Estrutura do Projeto

```text
Calculator/
│
└── Program.cs
```

O projeto é composto por uma única classe:

### `Program`

Contém o método `Main`, responsável por:

- Exibir o menu da calculadora;
- Ler os valores digitados pelo usuário;
- Processar a operação escolhida;
- Exibir o resultado.

---

## ▶️ Como Executar

### Pré-requisitos

- .NET SDK 6.0 ou superior

Verifique a instalação:

```bash
dotnet --version
```

### Clonar o repositório

```bash
git clone https://github.com/seu-usuario/Calculator.git
```

### Entrar na pasta do projeto

```bash
cd Calculator
```

### Executar

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text
=========================
== CALCULADORA SIMPLES ==
=========================

Funcionalidades: Adição, Subtração, Multiplicação e Divisão

Digite o primeiro número:
> 15

Selecione uma operação:
1 - Adição
2 - Subtração
3 - Multiplicação
4 - Divisão

> 3

Digite o segundo número:
> 4
```

### Saída

```text
O resultado da operação é: 60
```

---

## 📚 Conceitos Praticados

- Declaração de variáveis (`double` e `int`)
- Conversão de dados com `Convert.ToDouble()` e `Convert.ToInt32()`
- Estrutura de decisão `switch`
- Operadores aritméticos:
  - `+`
  - `-`
  - `*`
  - `/`
- Tratamento de exceção para divisão por zero
- Organização de código com `#region`

---

## 🚀 Possíveis Melhorias

- Implementar validação de entrada do usuário.
- Permitir múltiplos cálculos sem reiniciar a aplicação.
- Separar a lógica da calculadora em métodos ou classes específicas.
- Adicionar interface gráfica utilizando WPF ou Windows Forms.

---

## 👨‍💻 Autor

**André Elias Guimarães Vila**

Projeto desenvolvido como exercício prático de introdução à linguagem **C#** e programação orientada a objetos.