using System;

class Estoque
{
    private Produto[] produtos;
    private int contador;
    private const int capacidadeMaxima = 100;

    public Estoque()
    {
        produtos = new Produto[capacidadeMaxima];
        contador = 0;
    }

    public void AdicionarProduto(string nome, double preco, string marca, string modelo, string cor)
    {
        if (contador < capacidadeMaxima)
        {
            produtos[contador] = new Produto(nome, preco, marca, modelo, cor);
            contador++;
            Console.WriteLine("Produto adicionado!");
        }
        else
        {
            Console.WriteLine("Estoque cheio! Não é possível adicionar mais produtos.");
        }
    }

    public void ListarProdutos()
    {
        if (contador == 0)
        {
            Console.WriteLine("Nenhum produto no estoque.");
        }
        else
        {
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"{i + 1}. {produtos[i]}");
            }
        }
    }

    public void RemoverProduto(int indice)
    {
        if (indice >= 0 && indice < contador)
        {
            for (int i = indice; i < contador - 1; i++)
            {
                produtos[i] = produtos[i + 1];
            }
            produtos[contador - 1] = null;
            contador--;
            Console.WriteLine("Produto removido!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void EntradaEstoque(int indice, int quantidade)
    {
        if (indice >= 0 && indice < contador)
        {
            produtos[indice].EntradaEstoque(quantidade);
            Console.WriteLine("Entrada de estoque realizada!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }

    public void SaidaEstoque(int indice, int quantidade)
    {
        if (indice >= 0 && indice < contador)
        {
            produtos[indice].SaidaEstoque(quantidade);
            Console.WriteLine("Saída de estoque realizada!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }
}