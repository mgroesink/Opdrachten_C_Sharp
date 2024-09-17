using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models.Block3;

namespace Opdrachten_C_Sharp.Controllers
{
    public partial class Block3Controller : Controller
    {
        public IActionResult Example1()
        {
            return View(new PasswordOptions());
        }

        [HttpPost]
        public IActionResult Example1(PasswordOptions model)
        {
            if (ModelState.IsValid)
            {
                model.GeneratedPassword = model.GeneratePassword();
            }
            return View(model);
        }
    }
}
