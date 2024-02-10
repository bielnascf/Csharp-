namespace Exercicios29
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite dois números: ");
                int valor1 = int.Parse(Console.ReadLine());
                int valor2 = int.Parse(Console.ReadLine());
                double result = valor1 / valor2;

                Console.WriteLine($"O resultado da divisão é {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção ao tentar dividir um número por 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Exceção a forma de formatação as quais os dados foram inseridos.");
            }

        }
    }
}
