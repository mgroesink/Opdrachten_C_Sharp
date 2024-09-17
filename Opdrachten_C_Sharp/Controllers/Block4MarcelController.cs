using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models.Block4;
using System.Collections.Generic;
using System.Linq;

namespace Opdrachten_C_Sharp.Controllers
{
    public partial class Block4Controller : Controller
    {
        private List<Team> teams = new List<Team>
        {
            new Team { Name = "Ajax" },
            new Team { Name = "PSV" },
            new Team { Name = "FC Twente" },
            new Team { Name = "PEC Zwolle" },
                        new Team { Name = "Feyenoord" },
            new Team { Name = "Almere City" },
            new Team { Name = "Willem 2" },
            new Team { Name = "NAC" },
                        new Team { Name = "NEC" },
            new Team { Name = "FC Utrecht" },
            new Team { Name = "Heerenveen" },
            new Team { Name = "Heracles" },
                        new Team { Name = "Go Ahead Eagles" },
            new Team { Name = "Fortuna Sittard" },
            new Team { Name = "RKC" },
            new Team { Name = "Sparta" },
                        new Team { Name = "FC Groningen" },
            new Team { Name = "AZ" }

        };
        public IActionResult Example1()
        {
            ViewBag.Teams = teams.OrderBy(t=>t.Name);
            return View(new MatchResult());
        }

        [HttpPost]
        public IActionResult Example1(MatchResult result)
        {
            ViewBag.Teams = teams.OrderBy(t => t.Name);
            if (result.HomeTeam.Name == result.AwayTeam.Name)
            {
                ModelState.AddModelError("HomeTeam", "Thuis en uit team mogen niet hetzelfde zijn");
                return View(result);
            }
            if (ModelState.IsValid)
            {
                result.CalculatePoints();
            }
            return View(result);
        }
    }
}