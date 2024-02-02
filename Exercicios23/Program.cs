using Exercicios23.Entities;

namespace Exercicios23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account(20, "Gabriel Nascimento", 0.0);

            //BusinessAccount businessAccount = new BusinessAccount(40, "Gabriela Moraes", 200.00, 150.00);

            // UPCASTING -> Permite que o tipo de uma subClasse altere para o tipo da classe base (mae), pois toda subclasse está contida em uma classe mae.

            //Account account1 = businessAccount;
            //Account account2 = new BusinessAccount(30, "Thiago Moraes", 0.0, 350.00);
            //Account account3 = new SavingsAccount(50, "Silvia Regina", 0.0, 0.03);

            // DOWNCASTING -> Ao contrário do upcasting, este, permite que o tipo de uma classe mae altere para o tipo da SubClasse.

            //BusinessAccount account4 = (BusinessAccount)account2;

            ////BusinessAccount account5 = (BusinessAccount)account3;

            //if(account3 is BusinessAccount)
            //{
            //    Console.WriteLine("É uma businessAccount!");
            //    BusinessAccount account5 = account3 as BusinessAccount;
            //}
            //if(account3 is SavingsAccount)
            //{
            //    Console.WriteLine("É uma SavingsAccount!");
            //    SavingsAccount account5 = account3 as SavingsAccount;
            //}

            // --------------------------------------------------------------------------------------------------------------------------------------

            Account account1 = new Account(1010, "Gabriel Nascimento", 250.00);
            SavingsAccount account2 = new SavingsAccount(1020, "Gabriela Moraes", 200.00, 0.02);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance); 

            account1.WithDraw(50.00);
            account2.WithDraw(100.00);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}