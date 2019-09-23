using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLua;

namespace WowProfitCalcProfessions.Models
{
    public static class ItemRepository
    {
        public static void UpdateCosts()
        {
            Lua lua = new Lua();

            //lua.DoFile(@"C:\Auctionator.lua");
            lua.DoFile("./wwwroot/Auctionator.lua");
            const string tbPath = "AUCTIONATOR_PRICE_DATABASE.Yojamba_Horde"; // make server selectable 
            string[] items = { "Silk Cloth", "Bolt of Mageweave" };

            LuaTable opt = lua.GetTable(tbPath);
            Dictionary<object, object> dict = lua.GetTableDict(opt);
            foreach (KeyValuePair<object, object> de in dict)
            {
                string check = de.Key as string;
                LuaTable lt = lua.GetTable($"{tbPath}.{check}");
                foreach (KeyValuePair<object, object> specificItem in lua.GetTableDict(lt))
                {
                    string itemName = specificItem.Key as string;
                    if (itemName == "mr")
                        costs.Add(new ItemModel() { Name = check, Cost = Convert.ToInt32(specificItem.Value) });
                }
            }
        }
        private static List<ItemModel> costs = new List<ItemModel>();
        public static List<ItemModel> Costs => costs;
    }
}
