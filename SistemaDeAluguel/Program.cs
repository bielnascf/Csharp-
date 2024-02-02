﻿namespace SistemaDeAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudante = new Estudante[10];

            Console.WriteLine("Bem vindo ao Sistema de Aluguéis de Quartos");

            Console.Write("Quantos quartos você deseja alugar? ");
            int quantidadeAluguel = int.Parse(Console.ReadLine());

            for(int i = 1;  i <= quantidadeAluguel; i++)
            {
                Console.WriteLine($"Aluguel {i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudante[i] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos ocupados");
            for(int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine($"{i}: {estudante[i]}");
                }
            }

        }
    }
}