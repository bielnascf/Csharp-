namespace Exercicios17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Gabriel");
            nomes.Add("Mateus");
            nomes.Add("Matthew");
            nomes.Add("Pedro");
            nomes.Insert(2, "Victor");
            nomes.Insert(0, "Thiago");
            nomes.Insert(1, "Ana Clara");
            nomes.Insert(5, "Ana Beatriz");

            int i = 0;

            foreach (string nome in nomes)
            {
                Console.WriteLine($"{i}: {nome}");
                i++;
            }

            Console.WriteLine($"Tamando da lista: {nomes.Count}");

            Console.WriteLine("-----------------------------------------------");


            string nomeA1 = nomes.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeiro nome com a letra A: {nomeA1}");

            Console.WriteLine("-----------------------------------------------");

            string nomeA2 = nomes.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Último nome com a letra A: {nomeA2}");

            Console.WriteLine("-----------------------------------------------");

            int posicao1 = nomes.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Posição do primeiro nome com a letra A: {posicao1}");

            Console.WriteLine("-----------------------------------------------");

            int posicao2 = nomes.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Posição do ultimo nome com a letra A: {posicao2}");

            Console.WriteLine("-----------------------------------------------");

            List<string> nomes2 = nomes.FindAll(x => x.Length == 7);

            i = 0;
            Console.WriteLine("Nomes com 7 letras");

            foreach (string nome2 in nomes2)
            {
                Console.WriteLine($"{i}: {nome2}");
                i++;
            }

            Console.WriteLine("-----------------------------------------------");

            Console.Write("Quem você deseja remover da lista? ");
            string nomeRemovido = Console.ReadLine();
            nomes.Remove(nomeRemovido);

            i = 0;
            foreach (string nome in nomes)
            {
                Console.WriteLine($"{i} {nome}");
                i++;
            }
            Console.WriteLine($"Tamanho atual da lista: {nomes.Count}");

            Console.WriteLine("-----------------------------------------------");

            nomes.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("Removendo os nomes que começam com a letra 'M'.");

            i = 0;
            foreach (string nome in nomes)
            {
                Console.WriteLine($"{i} {nome}");
                i++;
            }
            Console.WriteLine($"Tamanho atual da lista: {nomes.Count}");

            Console.WriteLine("-----------------------------------------------");

            nomes.RemoveRange(2, 3);

            Console.WriteLine("Removendo os 3 próximos nomes a partir da posição 2");

            i = 0;
            foreach (string nome in nomes)
            {
                Console.WriteLine($"{i} {nome}");
                i++;
            }
            Console.WriteLine($"Tamanho atual da lista: {nomes.Count}");
        }
    }
}