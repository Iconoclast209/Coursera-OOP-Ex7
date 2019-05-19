using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class MutualFund : InvestmentAccount
    {
        #region FIELDS
        float serviceChargePercent;
        #endregion

        #region METHODS
        public MutualFund(float initialDeposit, float serviceChargeRate) : base(initialDeposit)
        {
            serviceChargePercent = serviceChargeRate;
        }

        public override void AddMoney(float amount)
        {
            //deduct service charge
            base.AddMoney(amount - (amount * serviceChargePercent));
        }

        public override void UpdateBalance()
        {
            //update investment values
            base.AddMoney(Balance * .07f);
        }

        public override string ToString()
        {
            return Balance.ToString();
        }
        #endregion
    }
}
