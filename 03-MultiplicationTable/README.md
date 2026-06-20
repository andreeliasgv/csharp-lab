# 🔢 Tabuada em C#

Projeto desenvolvido em **C#** como exercício introdutório de programação, com foco em **estruturas de repetição**, **variáveis**, **conversão de tipos** e **operadores aritméticos**.

A aplicação funciona via terminal (**CLI - Command Line Interface**) e exibe a tabuada de um número inteiro informado pelo usuário, de **1 a 10**.

---

## 📌 Funcionalidades

* Solicita um número inteiro ao usuário;
* Gera automaticamente a tabuada do número;
* Exibe os resultados de `1` até `10`;
* Utiliza laço de repetição `for` para percorrer os multiplicadores.

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 📂 Estrutura do Projeto

```text
MultiplicationTable/
│
└── Program.cs
```

* **Program.cs** → Contém toda a lógica da aplicação:

  * Exibição do cabeçalho;
  * Leitura do número informado pelo usuário;
  * Limpeza da tela (`Console.Clear()`);
  * Geração da tabuada utilizando um laço `for`;
  * Exibição dos resultados no console.

---

## ▶️ Como Executar

### Pré-requisitos

* .NET SDK 6.0 ou superior instalado.

Verifique a instalação:

```bash
dotnet --version
```

### Executando o projeto

Clone o repositório:

```bash
git clone https://github.com/andreeliasgv/csharp-lab.git
```

Acesse a pasta:

```bash
cd csharp-lab/MultiplicationTable
```

Execute:

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text
=================================
===========  Tabuada  ===========
=================================

Digite um número inteiro para mostrar sua tabuada:
> 7
```

### Saída

```text
Tabuada do 7:

7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70
```

---

## 🎯 Objetivos de Aprendizado

Este projeto foi desenvolvido para praticar:

* Declaração e utilização de variáveis;
* Conversão de tipos (`Convert.ToInt32`);
* Estruturas de repetição (`for`);
* Operadores aritméticos;
* Entrada e saída de dados no console;
* Organização básica de uma aplicação em C#.

---

## 📚 Conceitos Aplicados

* Variáveis e tipos primitivos;
* Estruturas de repetição;
* Conversão de dados;
* Operadores matemáticos;
* Interação com o usuário via terminal.

---

## 📜 Licença

Este projeto foi desenvolvido para fins educacionais e de aprendizado.
