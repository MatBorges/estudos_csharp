using System;

namespace estudos_csharp{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantiade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto pc = new Produto(nome, preco, quantidade);


    
            Console.WriteLine($"Nome: {pc.Nome}");

            Console.WriteLine("Nome denovo: ");
            

            pc.Nome = Console.ReadLine();

            Console.WriteLine($"Novo Nome: {pc.Nome}");

        }
    }
}
