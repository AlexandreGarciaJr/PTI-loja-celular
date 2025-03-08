using System;

class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque();

        while (true)
        {
            Console.WriteLine("\n[1] Novo Produto");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produto");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            Console.Write("Escolha uma opção: ");

            int escolha;
            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Opção inválida! Digite um número válido.");
                continue;
            }

            if (escolha == 1)
            {
                Console.Write("Informe o nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Informe a marca: ");
                string marca = Console.ReadLine();
                Console.Write("Informe o modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Informe a cor: ");
                string cor = Console.ReadLine();
                estoque.AdicionarProduto(nome, preco, marca, modelo, cor);
            }
            else if (escolha == 2)
            {
                estoque.ListarProdutos();
            }
            else if (escolha == 3)
            {
                estoque.ListarProdutos();
                Console.Write("Informe a posição do produto a ser removido: ");
                int indice = int.Parse(Console.ReadLine()) - 1;
                estoque.RemoverProduto(indice);
            }
            else if (escolha == 4)
            {
                estoque.ListarProdutos();
                Console.Write("Informe a posição do produto: ");
                int indice = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Informe a quantidade de entrada: ");
                int quantidade = int.Parse(Console.ReadLine());
                estoque.EntradaEstoque(indice, quantidade);
            }
            else if (escolha == 5)
            {
                estoque.ListarProdutos();
                Console.Write("Informe a posição do produto: ");
                int indice = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Informe a quantidade de saída: ");
                int quantidade = int.Parse(Console.ReadLine());
                estoque.SaidaEstoque(indice, quantidade);
            }
            else if (escolha == 0)
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}
