namespace Exercicios41
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1000 };
            p.Print("Anderson Macula");
            p.ProcessDoc("Anderson Macula");

            Scanner s = new Scanner() { SerialNumber = 1001 };
            Console.WriteLine(s.Scan());
            s.ProcessDoc("Kinteiro FJB");

            ComboDevice cd = new ComboDevice() { SerialNumber = 1002 };
            Console.WriteLine(cd.Scan());
            cd.Print("Le besquedo");
            cd.ProcessDoc("Le besquedo");
        }
    }
}