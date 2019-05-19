using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class EmployerSponsoredAccount : MutualFund
    {

        #region METHODS
        public EmployerSponsoredAccount(float initialDeposit, float serviceChargeRate) : base(initialDeposit,serviceChargeRate)
        {

        }

        public override void AddMoney(float amount)
        {
            //double the amount as employer match, then deposit using Mutual Fund
            base.AddMoney(amount * 2);
        }

        public override string ToString()
        {
            return Balance.ToString();
        }
        #endregion
    }
}
