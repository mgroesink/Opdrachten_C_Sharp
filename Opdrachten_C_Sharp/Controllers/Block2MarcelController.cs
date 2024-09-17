using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models.Block2;

namespace Opdrachten_C_Sharp.Controllers
{
    public partial class Block2Controller : Controller
    {
        public IActionResult Example1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Example1(Pizza model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.TotalPrice = model.GetTotalPrice().ToString("0.00");
            }
            return View(model);
        }
    }
}
