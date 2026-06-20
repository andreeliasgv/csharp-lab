# ➕ Soma dos Números de 1 até N em C#

Projeto simples desenvolvido em **C#** que calcula a soma de todos os números inteiros de **1 até N**, sendo **N** informado pelo usuário.

Este projeto foi criado como exercício prático para treinar estruturas de repetição, operadores aritméticos e manipulação de variáveis.

---

## 📌 Descrição

O programa solicita ao usuário um número inteiro que servirá como limite da soma.

Em seguida, utiliza um laço `for` para percorrer os números de `1` até `N`, acumulando o resultado em uma variável chamada `somatoria`.

### Exemplo

Se o usuário informar:

```text
N = 5
```

O programa realiza:

```text
1 + 2 + 3 + 4 + 5 = 15
```

Resultado:

```text
15
```

---

## 🎯 Conceitos Praticados

* Variáveis
* Conversão de tipos (`Convert.ToInt32`)
* Estruturas de repetição (`for`)
* Operadores aritméticos
* Acumuladores
* Entrada e saída de dados no console

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

Entre na pasta do projeto:

```bash
cd csharp-lab/NumberSum
```

Execute:

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text
=========================================================
===================  Soma de Números  ===================
=========================================================

Digite um número limite para somar com seus antecessores:
> 10
```

### Saída

```text
O resultado é: 55
```

---

## 📂 Estrutura do Projeto

```text
NumberSum/
│
├── Program.cs
└── NumberSum.csproj
```

---

## ⚙️ Funcionamento

1. O usuário informa um número inteiro.
2. O programa armazena esse valor na variável `limite`.
3. A variável `somatoria` é inicializada com `0`.
4. Um laço `for` percorre os números de `1` até `limite`.
5. A cada iteração, o valor atual é somado à variável acumuladora.
6. Ao final, o resultado total é exibido no console.

---

## 📚 Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 🎓 Objetivo do Projeto

Este projeto possui finalidade **educacional** e foi desenvolvido para praticar:

* Estruturas de repetição;
* Acumulação de valores;
* Operadores aritméticos;
* Entrada e saída de dados;
* Desenvolvimento de aplicações de console em C#.

---

✍️ Desenvolvido como exercício prático de programação em C#.
