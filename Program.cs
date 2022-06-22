using System;

namespace estudos_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pc = new Produto();

            pc.Nome = Console.ReadLine();
            pc.Preco = double.Parse(Console.ReadLine());
            pc.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {pc.Nome}");            

        }
    }
}
