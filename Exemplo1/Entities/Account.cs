using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balace { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balace)
        {
            Number = number;
            Holder = holder;
            Balace = balace;
        }

        public void Withdrew(double amount)
        {
            Balace -= amount;
        }
        public void Deposit(double amount)
        {
            Balace += amount;
        }

    }
}
