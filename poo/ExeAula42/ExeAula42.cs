using System;

namespace poo
{
    class ExeAula42
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Insira os dados do produto!");
            Console.Write("Nome? ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço? ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque? ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Numero de produtos a serem adicionados ao estoque? ");
            int QtdeAdicionada = int.Parse(Console.ReadLine());
            p.AdicionaEstoque(QtdeAdicionada);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Numero de produtos a serem removidas do estoque? ");
            int QtdeRemovida = int.Parse(Console.ReadLine());
            p.RemoveEstoque(QtdeRemovida);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
