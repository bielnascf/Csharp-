namespace Exercicios18
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] matriz = new double[2, 3];

            //Console.WriteLine(matriz.Length); // -> Quantidade de elementos dentro da matriz

            //Console.WriteLine(matriz.Rank); // -> Quantidade de linhas na matriz, serve para percorrer a matriz

            //Console.WriteLine(matriz.GetLength(0)); // -> Quantidade de linhas (1° dimensão da matriz)
            //Console.WriteLine(matriz.GetLength(1)); // -> Quantidade de colunas (2° dimensão da matriz) 

            Console.Write("Digite a dimensao N da matriz quadrática: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Agora, digite os valores dos elementos da matriz abaixo");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    int value = int.Parse(Console.ReadLine());

                    matriz[i, j] = value;
                }
            }

            Console.Write("Diagonal Principal: ");
            for (int i = 0;i < n; i++)
            {
                Console.Write($"{matriz[i,i]} ");
            }
            Console.WriteLine();

            Console.Write("Números Negativos: ");

            int negativeCount = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }
            Console.Write(negativeCount);
        }
    }
}
