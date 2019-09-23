using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NLua;

namespace WowProfitCalcProfessions.Models
{
    /*
     *TODO: Make this allow a user to put in what items they want, and see profit
     *
     */
    public class ProfessionCostModel
    {
       private int[] MatsAndQty;

        public ProfessionCostModel(params int[] MatsAndQty)
        {
            this.MatsAndQty = MatsAndQty;
        }

        public float ReturnProfit()
        {
            int totalCost = 0;

            return totalCost;
        }

        public void Test()
        {

        }
    }
}
