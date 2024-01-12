using System.Globalization;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite um número: ");
            //int numero1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite outro número: ");
            //int numero2 = int.Parse(Console.ReadLine());

            //int soma = numero1 + numero2;
            //int subtracao = numero1 - numero2;
            //int multiplicacao = numero1 * numero2;
            //int divisao = numero1 / numero2;

            //Console.WriteLine($"A soma entre os números digitados é {soma}.");
            //Console.WriteLine($"A subtração entre os números digitados é {subtracao}.");
            //Console.WriteLine($"A multiplicação entre os números digitados é {multiplicacao}.");
            //Console.WriteLine($"A divisão entre os números digitados é {divisao}.");

            // ---------------------------------------------------------------------------------------------------------

            //Console.WriteLine("Calcule a área de uma circunferência qualquer.");
            //Console.Write("Digite o valor do raio da circunferência: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double pi = 3.14159;
            //double areaCircunferencia = pi * Math.Pow(raio, 2);

            //Console.WriteLine($"A área da circunferência de raio {raio} é {areaCircunferencia.ToString("F4", CultureInfo.InvariantCulture)}.");

            // ----------------------------------------------------------------------------------------------------------

            //Console.WriteLine("Cálculo de salário baseado nas horas trabalhadas.");
            //Console.Write("Digite o seu identificador: ");
            //int identificador = int.Parse(Console.ReadLine());

            //Console.Write("Digite o valor recebido por hora trabalhada: ");
            //double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Digite a quantidade de horas trabalhadas: ");
            //int horasTrabalhadas = int.Parse(Console.ReadLine());

            //double salario = valorHora * horasTrabalhadas;

            //Console.WriteLine($"O funcionário de identificador N° {identificador} que ganha {valorHora.ToString("F2", CultureInfo.InvariantCulture)} reais por hora trabalhada e trabalhou {horasTrabalhadas} horas, possui salário de {salario.ToString("F2", CultureInfo.InvariantCulture)} reais.");

            // -----------------------------------------------------------------------------------------------------------

            //Console.WriteLine("Calcule o valor total do pedido");

            //int codigoProduto1, quantidadeProduto1, codigoProduto2, quantidadeProduto2;
            //double precoProduto1, precoProduto2, total;

            //Console.WriteLine("Produto 1: COD QTD R$");
            //string[] valores = Console.ReadLine().Split(' ');

            //codigoProduto1 = int.Parse(valores[0]);
            //quantidadeProduto1 = int.Parse(valores[1]);
            //precoProduto1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //Console.WriteLine("Produto 2: COD QTD R$");
            //valores = Console.ReadLine().Split(' ');

            //codigoProduto2 = int.Parse(valores[0]);
            //quantidadeProduto2 = int.Parse(valores[1]);
            //precoProduto2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = (precoProduto1 * quantidadeProduto1) + (precoProduto2 * quantidadeProduto2);

            //Console.WriteLine($"Valor total a pagar: R${total.ToString("F2", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------------------------------------------------------------------

            // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B

            //double A, B, C, areaTriangulo, areaCircunferencia, areaTrapezio, areaQuadrado, areaRetangulo, pi = 3.14159;

            //Console.WriteLine("Escreva a seguir o valor dos pontos A, B e C respectivamente, separados por espaço, para saber a área (cm²) de figuras geométricas. Ex: A B C");
            //string[] valores = Console.ReadLine().Split(' ');

            //A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //areaTriangulo = (A * C) / 2;
            //areaCircunferencia = pi * C * C;
            //areaTrapezio = (A + B) * C / 2;
            //areaQuadrado = B * B;
            //areaRetangulo = A * B;


            //Console.WriteLine($"Área do Triângulo: {areaTriangulo.ToString("F2", CultureInfo.InvariantCulture)}cm²");
            //Console.WriteLine($"Área da Circunferência: {areaCircunferencia.ToString("F2", CultureInfo.InvariantCulture)}cm²");
            //Console.WriteLine($"Área do Trapézio: {areaTrapezio.ToString("F2", CultureInfo.InvariantCulture)}cm²");
            //Console.WriteLine($"Área do Quadrado: {areaQuadrado.ToString("F2", CultureInfo.InvariantCulture)}cm²");
            //Console.WriteLine($"Área do Retângulo: {areaRetangulo.ToString("F2", CultureInfo.InvariantCulture)}cm²");



        }
    }
}
