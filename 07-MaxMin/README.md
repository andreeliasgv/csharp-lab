# 🔢 Maior e Menor Número em uma Lista - C#

Projeto simples desenvolvido em **C#** que permite ao usuário inserir vários números inteiros em uma lista e, ao final, exibe o **maior** e o **menor** valor armazenados.

Este projeto foi criado como exercício prático para treinar listas, estruturas de repetição e operações básicas sobre coleções.

---

## 📌 Descrição

O programa solicita ao usuário números inteiros de forma interativa.

Após cada inserção, o usuário pode escolher se deseja continuar adicionando novos valores ou encerrar a entrada de dados.

Quando a entrada termina, o sistema:

* Exibe todos os números cadastrados;
* Mostra o maior valor da lista;
* Mostra o menor valor da lista.

---

## 🎯 Conceitos Praticados

* Listas (`List<T>`)
* Estruturas de repetição (`while` e `foreach`)
* Entrada e saída de dados no console
* Conversão de tipos (`Convert.ToInt32`)
* Métodos de coleção (`Max()` e `Min()`)
* Controle de fluxo com condicionais

---

## ▶️ Como Executar

### Pré-requisitos

* .NET SDK 6.0 ou superior

Verifique a instalação:

```bash id="o5b1np"
dotnet --version
```

### Executando o projeto

Clone o repositório:

```bash id="d4uhmq"
git clone https://github.com/andreeliasgv/csharp-lab.git
```

Acesse a pasta:

```bash id="x09wt2"
cd csharp-lab/MaxMin
```

Execute:

```bash id="h9gbgi"
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text id="rzkvrv"
==========================================
=========  Maior e menor número  =========
==========================================

Informe o 1º número:
> 15

Deseja continuar?
(1) - Sim
(2) - Não

> 1

Informe o 2º número:
> 8

Deseja continuar?
(1) - Sim
(2) - Não

> 1

Informe o 3º número:
> 42

Deseja continuar?
(1) - Sim
(2) - Não

> 2
```

### Saída

```text id="4uw8jh"
Lista:

15 8 42

Maior valor da lista: 42
Menor valor da lista: 8
```

---

## 📂 Estrutura do Projeto

```text id="9v1e9f"
MaxMin/
│
├── Program.cs
└── MaxMin.csproj
```

---

## ⚙️ Funcionamento

1. O programa cria uma lista vazia do tipo `List<int>`.
2. O usuário informa números inteiros.
3. Após cada inserção, escolhe se deseja continuar.
4. Todos os valores são armazenados na lista.
5. Ao finalizar:

   * Os números são exibidos usando `foreach`;
   * O maior valor é obtido com `lista.Max()`;
   * O menor valor é obtido com `lista.Min()`.

---

## 📚 Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 🎓 Objetivo do Projeto

Este projeto possui finalidade **educacional** e foi desenvolvido para praticar:

* Manipulação de listas;
* Estruturas de repetição;
* Métodos utilitários de coleções;
* Entrada e saída de dados;
* Desenvolvimento de aplicações de console em C#.

---

✍️ Desenvolvido como exercício prático de programação em C#.
