namespace Exercicios15
{
    class Program
    {
        static void Main(string[] args)
        {
            //int resultado = Calculadora.Soma(5, 3, 9, 12, 20);

            //Console.WriteLine(resultado);

            // ----------------------------------------------------------------------------

            //int a = 10;

            //Calculadora.Triple(ref a);
            //Console.WriteLine(a);

            // ----------------------------------------------------------------------------

            int a = 10;
            int triple;

            Calculadora.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}