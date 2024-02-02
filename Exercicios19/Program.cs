namespace Exercicios19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m;  i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: " );
                    int value = int.Parse(Console.ReadLine());

                    matriz[i, j] = value;
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] == x)
                    {
                        Console.WriteLine($"Posição [{i}, {j}]");
                        if(j > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                        }
                        if(i > 0)
                        {
                            Console.WriteLine($"Cima: {matriz[i - 1, j]}");
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                        }
                        if(i < m - 1)
                        {
                            Console.WriteLine($"Baixo: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}