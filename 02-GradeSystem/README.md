# 📊 Sistema de Classificação de Notas em C#

Projeto desenvolvido em **C#** como exercício introdutório de programação, com foco em **estruturas condicionais**, **variáveis**, **conversão de tipos** e **entrada/saída de dados no console**.

A aplicação recebe uma nota de **0 a 10** e classifica automaticamente o aluno em uma das categorias definidas.

---

## 📌 Funcionalidades

O sistema classifica a nota de acordo com a seguinte regra:

|   Nota | Classificação |
| -----: | :------------ |
|  0 a 4 | Reprovado     |
|  5 a 6 | Recuperação   |
| 7 a 10 | Aprovado      |

Além disso, o programa realiza a validação da entrada, impedindo que sejam informados valores menores que **0** ou maiores que **10**.

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## 📂 Estrutura do Projeto

```text
GradeSystem/
│
└── Program.cs
```

* **Program.cs** → Contém toda a lógica da aplicação:

  * Exibição do cabeçalho do sistema;
  * Leitura da nota digitada pelo usuário;
  * Validação do intervalo permitido;
  * Classificação da nota utilizando estruturas condicionais (`if`, `else if` e `else`);
  * Exibição do resultado no console.

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
cd csharp-lab/GradeSystem
```

Execute:

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text
=====================================
= Sistema de Classificação de Notas =
=====================================

Digite a nota do aluno (0 a 10):
> 8
```

### Saída

```text
APROVADO
```

---

### Outro exemplo

#### Entrada

```text
Digite a nota do aluno (0 a 10):
> 5
```

#### Saída

```text
RECUPERAÇÃO
```

---

### Exemplo de erro

#### Entrada

```text
Digite a nota do aluno (0 a 10):
> 15
```

#### Saída

```text
NOTA INVÁLIDA. Por favor, insira um valor entre 0 e 10.
```

---

## 🎯 Objetivos de Aprendizado

Este projeto foi desenvolvido para praticar:

* Declaração e utilização de variáveis;
* Conversão de tipos (`Convert.ToInt32`);
* Estruturas condicionais (`if`, `else if` e `else`);
* Validação de dados de entrada;
* Entrada e saída de dados no console;
* Organização básica de uma aplicação em C#.

---

## 📜 Licença

Este projeto foi desenvolvido para fins educacionais e de aprendizado.
