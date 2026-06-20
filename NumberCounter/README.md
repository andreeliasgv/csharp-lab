# 🔢 Contador de Números em C#

Projeto simples desenvolvido em **C#** que lê um número inteiro informado pelo usuário e exibe todos os números de **1 até N** no console.

Este projeto foi criado como exercício prático para treinar estruturas de repetição, variáveis e conversão de tipos.

---

## 📌 Descrição

O programa solicita ao usuário um número inteiro que será utilizado como limite para a contagem.

Após a entrada dos dados, o sistema utiliza um laço `for` para imprimir todos os números começando em **1** até o valor informado.

### Conceitos praticados

* Variáveis
* Conversão de tipos (`Convert.ToInt32`)
* Estruturas de repetição (`for`)
* Entrada e saída de dados no console
* Organização básica de aplicações C#

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

Acesse a pasta:

```bash
cd csharp-lab/NumberCounter
```

Execute:

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text
===================================
======  Contador de Números  ======
===================================

Escolha um limite para o contador:
> 10
```

### Saída

```text
1
2
3
4
5
6
7
8
9
10
```

---

## 📂 Estrutura do Projeto

```text
NumberCounter/
│
├── Program.cs
└── NumberCounter.csproj
```

---

## ⚙️ Funcionamento

1. O usuário informa um número inteiro.
2. O programa armazena esse valor na variável `limite`.
3. Um laço `for` inicia em `1`.
4. Enquanto o contador for menor ou igual ao limite, o número é exibido no console.
5. A contagem termina quando o limite é atingido.

---

## 📚 Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 🎯 Objetivo do Projeto

Este projeto tem finalidade **educacional**, servindo para praticar:

* Estruturas de repetição;
* Manipulação de variáveis;
* Conversão de dados;
* Desenvolvimento de aplicações de console em C#.

---

✍️ Desenvolvido como exercício prático de programação em C#.
