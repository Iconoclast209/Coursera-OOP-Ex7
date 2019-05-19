using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class InvestmentAccount
    {
        #region FIELDS
        float balance;
        #endregion

        #region PROPERTIES
        public float Balance
        {
            get { return balance; }
        }
        #endregion

        #region METHODS
        public InvestmentAccount(float initialDeposit)
        {
            balance = initialDeposit;
        }

        public virtual void AddMoney(float amount)
        {
            balance += amount;
        }

        public virtual void UpdateBalance()
        {

        }
                
        #endregion
    }
}
