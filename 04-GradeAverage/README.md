# 📚 Média de 3 Notas em C#

Projeto simples desenvolvido em **C#** para calcular a média de três notas informadas pelo usuário e determinar se o aluno foi **aprovado** ou **reprovado**, de acordo com uma regra de negócio pré-definida.

---

## 📌 Descrição

O programa solicita ao usuário três notas, armazena os valores em um **array**, calcula a média aritmética e exibe o resultado.

Após o cálculo, a aplicação verifica:

- Média **maior ou igual a 7** → **APROVADO**
- Média **menor que 7** → **REPROVADO**

---

## 🎯 Objetivos da Atividade

Este exercício tem como foco a prática dos seguintes conceitos:

- Variáveis
- Arrays
- Conversão de tipos (`Convert.ToDouble`)
- Operadores aritméticos
- Estruturas condicionais (`if/else`)
- Entrada e saída de dados no console

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET
- Console Application

---

## 📂 Estrutura do Projeto

```text
GradeAverage
│
└── Program.cs
```

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
git clone https://github.com/andreeliasgv/csharp-lab.git
```

### Entrar na pasta do projeto

```bash
cd csharp-lab/GradeAverage
```

### Executar

```bash
dotnet run
```

---

## 🖥️ Exemplo de Uso

### Entrada

```text
==========================================
===========  Média de 3 Notas  ===========
==========================================

Digite a primeira nota:
> 8

Digite a segunda nota:
> 7.5

Digite a terceira nota:
> 6
```

### Saída

```text
A média das notas é 7,166666666666667

APROVADO
```

---

## ⚙️ Regra de Aprovação

| Média | Situação |
|------:|:--------|
| ≥ 7,0 | APROVADO |
| < 7,0 | REPROVADO |

---

## 📖 Conceitos Aplicados

Durante o desenvolvimento deste projeto foram utilizados:

- Declaração e manipulação de arrays
- Entrada de dados pelo console
- Conversão de strings para números
- Cálculo de média aritmética
- Estruturas condicionais
- Organização básica de uma aplicação Console em C#

---

## 🚀 Possíveis Melhorias

Algumas melhorias que podem ser implementadas futuramente:

- Validar se as notas estão entre 0 e 10
- Permitir quantidade variável de notas
- Exibir a média formatada com duas casas decimais
- Implementar recuperação escolar
- Utilizar laços de repetição para evitar repetição de código

---

## ✍️ Autor

Desenvolvido por **André Elias Guimarães Vila** como exercício prático de C# para estudo de arrays, condicionais e operações matemáticas.