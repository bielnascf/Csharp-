using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios28.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
        public Person() { }
        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
