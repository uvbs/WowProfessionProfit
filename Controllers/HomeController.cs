using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WowProfitCalcProfessions.Models;

namespace WowProfitCalcProfessions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("WoWHome");
        }
        public IActionResult Update()
        {
            ItemRepository.UpdateCosts();
            return View("WoWHome");
        }
        public ViewResult Pricing()
        {
            List<String> itemRequest = new List<string>(){"Bolt of Mageweave", "Mageweave Cloth", "Silk Cloth", "Bolt of Silk"};
            //ProfessionCostModel cost = new ProfessionCostModel(); // split this model
            IEnumerable<ItemModel> ret = ItemRepository.Costs.Where(x => itemRequest.Contains(x.Name));
            return View(ret);
        }
        public ViewResult Pricing2()
        {
            List<String> itemRequest = new List<string>() { "Bolt of Mageweave", "Mageweave Cloth", "Silk Cloth", "Bolt of Silk" };
            //ProfessionCostModel cost = new ProfessionCostModel(); // split this model
            IEnumerable<ItemModel> ret = ItemRepository.Costs;
            return View("Pricing",ret);
        }

    }
}
