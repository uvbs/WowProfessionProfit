using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using WowProfitCalcProfessions.Extensions;
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
        public ViewResult PricingMageweaveBag()
        {
            List<String> itemRequest = new List<string>(){"Bolt of Mageweave", "Silken Thread"};
            int itemLen = itemRequest.Count;
            int[] qty = {4, 2};
            List<ItemModel> retList = new List<ItemModel>();
            for (int i = 0; i < itemLen; i++)
                retList.Add(ItemRepository.FindSpecificItem(itemRequest[i]));

            ProfessionCostModel bagTest = new ProfessionCostModel(retList.Select(c => c.Cost).ToArray(), qty);
            retList.Add(bagTest.ReturnToItem(" Item: Mageweave Bag - Built by mats"));

            return View("Pricing",retList);
        }

        public ViewResult PricingSilkBag()
        {
            List<String> itemRequest = new List<string>() { "Bolt of Silk Cloth", "Heavy Leather", "Fine Thread" };
            int itemLen = itemRequest.Count;
            int[] qty = { 3,2,3 };
            List<ItemModel> retList = new List<ItemModel>();
            for (int i = 0; i < itemLen; i++)
                retList.Add(ItemRepository.FindSpecificItem(itemRequest[i]));

            ProfessionCostModel bagTest = new ProfessionCostModel(retList.Select(c => c.Cost).ToArray(), qty);
            retList.Add(bagTest.ReturnToItem(" Item: Small Silk Pack - Built by mats"));

            return View("Pricing", retList);
        }

        public ViewResult Pricing2()
        {
            IEnumerable<ItemModel> ret = ItemRepository.Costs;
            return View("Pricing",ret);
        }

    }
}
