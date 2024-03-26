using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using MvcIplApp.Data;
using MvcIplApp.Models;

namespace MvcIplApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TeamController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Team> objTeamList=_db.Teams.ToList();
            return View(objTeamList);
        }
        public IActionResult Create() {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Team objTeam)
        {
            if (ModelState.IsValid)
            {
                _db.Teams.Add(objTeam);
                _db.SaveChanges();
            }
           
            return RedirectToAction("Index","Team");
        }
        public IActionResult Edit(int Id)
        {
            Team detailTeam = _db.Teams.FirstOrDefault(team => team.Id == Id);
            if(detailTeam==null)
            {
                return NotFound();
            }
            return View(detailTeam);
        }
        [HttpPost]
        public IActionResult Edit(Team objTeam)
        {
            if (ModelState.IsValid)
            {
                _db.Teams.Update(objTeam);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Details(int Id)
        {
            Team detailTeam = _db.Teams.FirstOrDefault(team => team.Id == Id);
            return View(detailTeam);
        }
        public IActionResult Delete(int Id)
        {
            var teamToDelete = _db.Teams.FirstOrDefault(team => team.Id == Id);
          
            if (teamToDelete != null)
            {
                
                    _db.Teams.Remove(teamToDelete);
                    _db.SaveChanges();

            }
            return RedirectToAction("Index");




        }
    }
}
