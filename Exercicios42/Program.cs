using Exercicios42.Entities;

namespace Exercicios42
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    
                    foreach (Employee employee in list)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}