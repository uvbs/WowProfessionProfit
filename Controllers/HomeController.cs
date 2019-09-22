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

        public ViewResult Pricing()
        {
            ProfessionCostModel cost = new ProfessionCostModel();
            cost.UpdateCosts();
            IEnumerable<ItemModel> ret = cost.Costs;
            return View(ret);
        }

      
    }
}
