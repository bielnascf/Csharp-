namespace Exercicios33
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs); // sr = File.OpenText(path);

                while (!sr.EndOfStream) // <<<- Lógica para ler todas as linhas do arquivo
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");
            }
            finally
            {
                if( fs != null ) fs.Close();    
                if( sr != null ) sr.Close();
            }
        }
    }
}