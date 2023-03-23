using System;
using System.Globalization;

namespace ProjetoInternato
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudantes[] vect = new Estudantes[20];


            Console.Write("Quantos quartos serão alugados? ");
            int Q = int.Parse(Console.ReadLine());
            Console.WriteLine("--------");

            for (int i = 0; i < Q; i++)
            {
                Console.WriteLine($"aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("------");
                vect[quarto] = new Estudantes(email,nome);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 20; i++)
            {
                if( vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);

                }
            }



        }
    }
}
