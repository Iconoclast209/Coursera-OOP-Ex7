using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class Program
    {
        


        static void Main(string[] args)
        {
            List<InvestmentAccount> accounts = new List<InvestmentAccount>();
            SavingsAccount sa = new SavingsAccount(100f, 0.2f);
            MutualFund mf = new MutualFund(100f, 0.03f);
            EmployerSponsoredAccount esa = new EmployerSponsoredAccount(100f, 0.02f);
            accounts.Add(sa);
            accounts.Add(mf);
            accounts.Add(esa);

            foreach(InvestmentAccount ia in accounts)
            {
                Console.WriteLine(ia.ToString());
            }
            Console.WriteLine();

            foreach (InvestmentAccount ia in accounts)
            {
                ia.UpdateBalance();
            }

            foreach (InvestmentAccount ia in accounts)
            {
                Console.WriteLine(ia.ToString());
            }
            Console.WriteLine();

            foreach (InvestmentAccount ia in accounts)
            {
                ia.AddMoney(100f);
            }

            foreach (InvestmentAccount ia in accounts)
            {
                Console.WriteLine(ia.ToString());
            }
            Console.WriteLine();


        }
    }
}
