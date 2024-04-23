using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamAdda.Models;
using WEBAPICodeFirst.Models;
using Newtonsoft.Json;

namespace ExamAdda.Controllers
{
    
    public class UsersController : Controller
    {
        private readonly ExamDbcontext _context;
        private string url = "https://localhost:7177/api/Users";
        private HttpClient client=new HttpClient();
        public UsersController(ExamDbcontext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            List<User> users = new List<User>();
            HttpResponseMessage response=client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                String result=response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<User>>(result);
                if (data != null)
                {
                    users = data;
                }

            }
            return View(users);
        }

      

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Password,Role,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Active")] User user)
        {

            return View(user);
        }


        public IActionResult SignIn()
        {
            ViewBag.message = string.Empty;
            return View();
        }
        public IActionResult StudentDashboard(String? user)
        {
            
            if (user != null)
            {
                User usernew = JsonConvert.DeserializeObject<User>(user);
                return View(usernew);
            }
            return View("Signin");
        }
        public IActionResult AdminDashboard(String? user)
        {
           
            if (user != null)
            {
                User usernew = JsonConvert.DeserializeObject<User>(user);
                return View(usernew);
            }
            return View("SignIn");
        }

        [HttpGet]
        public IActionResult ExamDashboard(int examId,int studentId,int duration, int marks, String examName)
        {
            ViewBag.ExamId = examId;
            ViewBag.StudentId = studentId;
            ViewBag.Duration = duration*60;
            ViewBag.examName = examName;
            ViewBag.marks = marks;
            if(examName != null || duration!<0)
            return View();

            return View("SignIn");
        }

        public IActionResult Details(int id)
        {
            ViewBag.userId =id;
                return View();
            
        }


        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.userId = id;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditQuestion(int id)
        {
            ViewBag.questionId = id;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditExam(int id)
        {
            ViewBag.examId = id;
            return View();
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Password,Role,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Active")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
