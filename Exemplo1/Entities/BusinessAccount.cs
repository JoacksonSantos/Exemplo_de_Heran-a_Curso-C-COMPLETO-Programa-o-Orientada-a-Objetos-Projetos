using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exemplo1.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { 
        
        }

        public BusinessAccount(int number, string holder, double balace ,double loanLimit) : base(number, holder, balace)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balace += amount;
            }
            
        }
    }
}
