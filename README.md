# Exercícios Resolvidos em C#

## Integrantes do Grupo
- Gabriel Henrique Vaz dos Santos RGM 37340611
- Edson Valério Veloso - RGM 38014335
- Anderson Torres Junior - RGM 37108182

---

## Questões Resolvidas

1. Validador de Senhas Fortes  
2. Tabuada Completa com Laço de Repetição  
3. Cálculo de Fatorial com While  
4. Conversor de Temperaturas com Menu  
5. Verificador de Palíndromos  
6. Cadastro Simples de Produtos  
7. Soma de Números Pares de um Array  
8. Cálculo de IMC com Classificação  
9. Jogo de Adivinhação  
10. Lista de Tarefas (To-Do List)

---

## Descrição Funcional dos Exercícios

### 1. Validador de Senhas Fortes  
Solicita uma senha do usuário e verifica se ela atende critérios de segurança (mínimo de 8 caracteres, letras maiúsculas e minúsculas, número e caractere especial).

### 2. Tabuada Completa com Laço de Repetição  
Exibe a tabuada de 1 a 10 utilizando o laço de repetição `for`.

### 3. Cálculo de Fatorial com While  
Solicita um número inteiro e calcula seu fatorial utilizando o laço `while`.

### 4. Conversor de Temperaturas com Menu  
Permite ao usuário escolher entre converter Celsius para Fahrenheit ou Fahrenheit para Celsius.

### 5. Verificador de Palíndromos  
Verifica se uma string inserida pelo usuário é um palíndromo (ou seja, se pode ser lida da mesma forma de trás para frente).

### 6. Cadastro Simples de Produtos  
Permite o cadastro de produtos com nome, preço e quantidade, e exibe o valor total em estoque.

### 7. Soma de Números Pares de um Array  
Solicita 10 números ao usuário e realiza a soma apenas dos números pares.

### 8. Cálculo de IMC com Classificação  
Recebe peso e altura, calcula o IMC e classifica o resultado em categorias como "abaixo do peso", "normal", "sobrepeso", etc.

### 9. Jogo de Adivinhação  
Gera um número aleatório entre 1 e 100 e permite que o usuário tente adivinhar o valor com base em tentativas.

### 10. Lista de Tarefas (To-Do List)  
Permite adicionar tarefas a uma lista, visualizar todas e marcar tarefas como concluídas com base no índice.

---

## Documentação Detalhada

### Exercício 1: Validador de Senhas Fortes

**Objetivo**:  
Garantir que a senha digitada seja considerada forte de acordo com critérios de segurança.

**Critérios de validação**:
- Pelo menos 8 caracteres
- Pelo menos uma letra maiúscula
- Pelo menos uma letra minúscula
- Pelo menos um número
- Pelo menos um caractere especial

**Lógica Utilizada**:
- `string.Any` para verificação de tipos de caracteres
- `char.IsUpper` (Verifica se contém uma letra maiúscula), `char.IsLower` (Verifica se contém uma letra minúscula), `char.IsDigit` (Verifica se contém um número), e `!char.IsLetterOrDigit` (Verifica se contém um caráctere especial)

### Exercício 10: Lista de Tarefas (ToDo List)

**Objetivo**:
Gerenciar tarefas inseridas pelo usuário e permitir marcar como concluídas.

**Funcionalidades**:
- Adicionar Tarefas
- Visualizar Tarefas
- Marcar tarefas como concluídas atráves de um menu de seleção

**Lógica Utilizada**:
- `List<string>` para receber as tarefas
- `TryParse` para fazer tratamentos de erros e exceções através da entrada do usuário, que gera uma nova variável "índice" e através do índice, fazemos as condicionais para o método.

