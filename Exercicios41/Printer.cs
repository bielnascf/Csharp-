using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios41
{
    class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Pinter Print: {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer Print Processing: {document}");
        }
    }
}
