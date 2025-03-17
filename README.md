# Exercício: Cálculo de Parcelas com Juros e Taxas

## Descrição

Este exercício tem como objetivo calcular o valor das parcelas de um contrato, levando em consideração a divisão do valor total do contrato em um número de parcelas definido, e aplicando juros e taxas sobre o valor de cada parcela. O programa permite a entrada de dados como o valor total do contrato, o número de parcelas e a data de início do contrato, e retorna o valor de cada parcela, com juros e taxas aplicados de forma incremental.

## Requisitos

- O valor total do contrato é dividido igualmente entre as parcelas.
- A cada mês, aplica-se um **juros de 1%** sobre o valor base da parcela.
- Após aplicar os juros, uma **taxa de 2%** é adicionada sobre o valor da parcela com juros.
- O programa deve exibir a data de vencimento de cada parcela e o valor final de cada uma, com juros e taxas, no formato `dd/MM/yyyy - valor`.

## Funcionalidade

1. O usuário insere o número de parcelas, a data de início do contrato, e o valor total do contrato.
2. O valor total do contrato é dividido igualmente pelas parcelas.
3. Para cada parcela, são aplicados os seguintes cálculos:
    - **Juros**: 1% sobre o valor base da parcela multiplicado pelo número de meses.
    - **Taxa**: 2% sobre o valor da parcela após o cálculo dos juros.
4. O programa retorna a data de vencimento de cada parcela (baseada na data de início) e o valor total da parcela (com juros e taxas).

## Exemplo de Entrada e Saída

### Entrada:
- Valor do contrato: R$600,00
- Número de parcelas: 3
- Data de início do contrato: 25/07/2018

### Saída:
![image](https://github.com/user-attachments/assets/9beb5506-6105-4983-ab23-2eb4bc104dbe)

## Tecnologias Utilizadas

- **C#**: Linguagem de programação utilizada para resolver o exercício.
- **.NET**: Framework para execução do código.

## Como Rodar o Projeto

1. Clone este repositório.
2. Abra o projeto no Visual Studio ou na sua IDE de preferência.
3. Execute o código para ver os cálculos das parcelas.

---

Sinta-se à vontade para modificar, testar e melhorar este projeto!

