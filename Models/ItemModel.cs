using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WowProfitCalcProfessions.Models
{
    public class ItemModel
    {
        public string Name;
        public int Cost;

        public ItemModel(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}
