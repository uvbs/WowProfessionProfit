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
        public void UpdateCosts()
        {
            Lua lua = new Lua();

            lua.DoFile(@"C:\Auctionator.lua");
            const string tbPath = "AUCTIONATOR_PRICE_DATABASE.Yojamba_Horde"; // make server selectable 
            string[] items = { "Silk Cloth", "Bolt of Mageweave" };

            LuaTable opt = lua.GetTable(tbPath);
            Dictionary<object, object> dict = lua.GetTableDict(opt);
            foreach (KeyValuePair<object, object> de in dict)
            {
                string check = de.Key as string;
                if (Array.IndexOf(items, check) >= 0)
                {
                    LuaTable lt = lua.GetTable($"{tbPath}.{check}");
                    foreach (KeyValuePair<object, object> specificItem in lua.GetTableDict(lt))
                    {
                        string itemName = specificItem.Key as string;
                        if (itemName == "mr")
                            costs.Add(new ItemModel() { Name = check, Cost = Convert.ToInt32(specificItem.Value) });
                    }
                }
            }
        }

        private List<ItemModel> costs = new List<ItemModel>();
        public List<ItemModel> Costs => costs;

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
