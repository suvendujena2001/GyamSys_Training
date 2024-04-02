using CRUD_ASP.Data;
using CRUD_ASP.Models;
using CRUD_ASP.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.Controllers
{
    public class StudentsController : Controller
        
    {
        private readonly AppDBContext dBContext;

        public StudentsController(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };

            await dBContext.Students.AddAsync(student);
            await dBContext.SaveChangesAsync();
              return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dBContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid Id)
        {
            var students = await dBContext.Students.FindAsync(Id);
            return View(students);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Student Viewmodel)
        {
            var students = await dBContext.Students.FindAsync(Viewmodel.Id);

            if (students is not null)
            {
                students.Name = Viewmodel.Name;
                students.Email = Viewmodel.Email;
                students.Phone = Viewmodel.Phone;
                students.Subscribed = Viewmodel.Subscribed;
                await dBContext.SaveChangesAsync();

            }
            return RedirectToAction("List", "Students");
        }


        [HttpPost]

        public async Task<IActionResult> Delete(Student Viewmodel)
        {
            var students = await dBContext.Students.AsNoTracking().FirstOrDefaultAsync( X=> X.Id == Viewmodel.Id);
            if(students is not null)
            {
                dBContext.Students.Remove(Viewmodel);

                await dBContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        
         }
    }
}
