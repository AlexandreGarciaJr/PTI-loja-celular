# Projeto Controle de Produtos Senac 2025

- ### Esta API demonstra o funcionamento de uma Web API de controle de caixa de uma loja de eletrônicos

## Principais Tecnologias
![Blog](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
)
## Funcões
- Adiciona produto
- Adiciona características do produto
- Lista produto
- Remove produto
- Adiciona estoque
- Remove estoque

## Diagrama de Classes

```mermaid
classDiagram
    direction TB

    class Produto {
        - string Nome
        - double Preco
        - string Marca
        - string Modelo
        - string Cor
        - int Estoque
        + Produto(string nome, double preco, string marca, string modelo, string cor)
        + AumentarEstoque(int quantidade)
        + DiminuirEstoque(int quantidade)
        + ToString() string
    }

    class Estoque {
        - Produto[] produtos
        - int contador
        - const int capacidadeMaxima = 100
        + Estoque()
        + AdicionarProduto(string nome, double preco, string marca, string modelo, string cor)
        + ListarProdutos()
        + RemoverProduto(int indice)
        + EntradaEstoque(int indice, int quantidade)
        + SaidaEstoque(int indice, int quantidade)
    }

    class Program {
        + Main()
    }

    %% Relacionamentos
    Estoque "1" --> "*" Produto : contém
    Program --> Estoque : utiliza
```