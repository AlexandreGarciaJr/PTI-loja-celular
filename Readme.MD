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
    class Produto {
        - string Nome
        - double Preco
        - string Marca
        - string Modelo
        - string Cor
        - int Estoque
        + Produto(string, double, string, string, string)
        + AumentarEstoque(int)
        + DiminuirEstoque(int)
        + ToString() string
    }

    class Estoque {
        - Produto[] produtos
        - int contador
        - const int capacidadeMaxima
        + Estoque()
        + AdicionarProduto(string, double, string, string, string)
        + ListarProdutos()
        + RemoverProduto(int)
        + EntradaEstoque(int, int)
        + SaidaEstoque(int, int)
    }

    class Program {
        + Main()
    }

    Estoque "1" --> "*" Produto
```