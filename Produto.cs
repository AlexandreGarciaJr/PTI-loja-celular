using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Estoque { get; set; } // Estoque inicial será 0

    public Produto(string nome, double preco, string marca, string modelo, string cor)
    {
        Nome = nome;
        Preco = preco;
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Estoque = 0;
    }

    public void EntradaEstoque(int quantidade)
    {
        Estoque += quantidade;
    }

    public void SaidaEstoque(int quantidade)
    {
        if (Estoque >= quantidade)
        {
            Estoque -= quantidade;
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente no estoque.");
        }
    }

    public override string ToString()
    {
        return $"{Nome} ({Preco:C}) - {Estoque} no estoque - {Marca}, {Modelo}, {Cor}";
    }
}