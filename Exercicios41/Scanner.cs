using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios41
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Scanner Scan Processing: {document}");
        }

        public string Scan()
        {
            return "Scanner Scan Result";
        }
    }
}
