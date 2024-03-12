using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.web.Data;
using StudentPortal.web.Models;
using StudentPortal.web.Models.Entities;

namespace StudentPortal.web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        //to make use of the dbcontext 
        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Add(AddStudentViewModel viewmodel)
        {
            //to create a new entity of the student so that we can pass it in the addasync function
            var student = new Student
            {
                Name = viewmodel.Name,
                Phone = viewmodel.Phone,
                Email = viewmodel.Email,
            };


            await dbContext.Students.AddAsync(student);

            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet] 
        public async Task<IActionResult> List()
        {
            var students= await dbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            return View(student);
        }

        [HttpPost] 
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.Id);


            if(student is not null)
            {
                student.Name = viewModel.Name;
                student.Phone = viewModel.Phone;
                    student.Email = viewModel.Email;

                await dbContext.SaveChangesAsync();
            }

            //whenever the update is sucessfull we are returning back to the student list
            return RedirectToAction("List" , "Students");
        }

        

        [HttpPost]
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(  x => x.Id==viewModel.Id);

            if(student is not null)
            {
                dbContext.Students.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        }

    }
}
