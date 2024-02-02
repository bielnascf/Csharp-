namespace Exercicios16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Gabriel", "João", "Pedro", "Thiago" };

            //for(int i = 0; i < nomes.Length; i++)
            //{
            //    Console.WriteLine(nomes[i]);
            //}

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}