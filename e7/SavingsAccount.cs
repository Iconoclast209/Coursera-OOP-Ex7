using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class SavingsAccount : InvestmentAccount
    {
        #region FIELDS
        float interestRate;
        #endregion

        #region METHODS
        public SavingsAccount(float initialDeposit, float rate) : base(initialDeposit)
        {
            interestRate = rate;
        }

        public override void UpdateBalance()
        {
            //accrue interest
            base.AddMoney(Balance * interestRate);
            
        }

        public override string ToString()
        {
            return Balance.ToString();
        }
        #endregion
    }
}
