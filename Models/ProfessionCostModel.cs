using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NLua;

namespace WowProfitCalcProfessions.Models
{
    public class ProfessionCostModel
    {
        private int[] matCosts;
        private int[] matQuantities;

        public ProfessionCostModel(int[] matCosts, int[] matQuantity)
        {
            this.matCosts = matCosts;
            this.matQuantities = matQuantity;
        }

        public int ReturnProfit()
        {
            int outcomeCost = 0;
            for (int i = 0; i < matCosts.Length; i++)
            {
                outcomeCost += matCosts[i] * matQuantities[i];
            }
            return outcomeCost;
        }

        public ItemModel ReturnToItem(string customName)
        {
            return new ItemModel(customName,ReturnProfit());
        }
    }
}
