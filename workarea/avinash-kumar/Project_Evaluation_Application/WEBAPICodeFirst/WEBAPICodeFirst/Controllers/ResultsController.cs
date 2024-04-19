using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPICodeFirst.Models;

namespace WEBAPICodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly ApplicatiobDbcontext _context;

        public ResultsController(ApplicatiobDbcontext context)
        {
            _context = context;
        }

        // GET: api/Results
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Result>>> GetResults()
        {
            return await _context.Results.ToListAsync();
        }

        // GET: api/Results/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Result>> GetResult(int id)
        {
            var result = await _context.Results.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }


        [HttpGet("ByStudentId/{studentId}")]
        public IActionResult GetResultsByStudentId(int studentId)
        {
            try
            {
                // Retrieve results of exams taken by the student from the database
                var results = _context.Results
                    .Where(r => r.StudentIdFk == studentId)
                    .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        // PUT: api/Results/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResult(int id, Result result)
        {
            if (id != result.ResultId)
            {
                return BadRequest();
            }

            _context.Entry(result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Results
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Result>> PostResult(Result result)
        {
            _context.Results.Add(result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResult", new { id = result.ResultId }, result);
        }

        [HttpGet]
        [Route("api/examresults/{examId}")]
        public IActionResult GetExamResults(int examId)
        {
            // Fetch results for a specific exam
            var results = _context.Results.Where(r => r.ExamId_Fk == examId).ToList();

            if (results.Count == 0)
            {
                return NotFound();
            }

            // Calculate average score for the specific exam
            double averageScore = results.Average(r => r.Score);

            //Response
            var response = results.Select(r => new
            {
                ExamName = r.ExamName,
                StudentName = _context.Users.FirstOrDefault(u => u.Id == r.StudentIdFk)?.Name,
                StudentEmail = _context.Users.FirstOrDefault(u => u.Id == r.StudentIdFk)?.Email,
                Score = r.Score,
                FullMarks = r.FullMarks,
                Performance = CalculatePerformanceLevel(averageScore, r.Score)
            });

            return Ok(response);
        }


        // Download report api 
        [HttpGet]
        [Route("DownloadReports")]
        public IActionResult DownloadAllReports()
        {
            // Retrieve all results from the database
            var allResults = _context.Results.OrderBy(r => r.ExamId_Fk).ToList();

            // Create a new Excel workbook
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Reports");

            // Write headers
            worksheet.Cell(1, 1).Value = "Exam ID";
            worksheet.Cell(1, 2).Value = "Exam Name";
            worksheet.Cell(1, 3).Value = "Student Name";
            worksheet.Cell(1, 4).Value = "Student Email";
            worksheet.Cell(1, 5).Value = "Score";
            worksheet.Cell(1, 6).Value = "Full Marks";

            // Write data
            int row = 2;
            foreach (var result in allResults)
            {
                // Fetch student details for each result
                var student = _context.Users.FirstOrDefault(u => u.Id == result.StudentIdFk);

                worksheet.Cell(row, 1).Value = result.ExamId_Fk;
                worksheet.Cell(row, 2).Value = result.ExamName;
                worksheet.Cell(row, 3).Value = student?.Name; 
                worksheet.Cell(row, 4).Value = student?.Email; 
                worksheet.Cell(row, 5).Value = result.Score;
                worksheet.Cell(row, 6).Value = result.FullMarks;
                row++;
            }

            // Save the workbook to a memory stream
            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                stream.Position = 0;

                // Return the Excel file
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "reports.xlsx");
            }
        }

        // Helper method to calculate performance level
        private string CalculatePerformanceLevel(double averageScore,int score)
        {
            if (score >= averageScore)
            {
                return "Excellent";
            }
            else if (score >= averageScore-10)
            {
                return "Good";
            }
            else
            {
                return "Bad";
            }
        }

        // DELETE: api/Results/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResult(int id)
        {
            var result = await _context.Results.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            _context.Results.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResultExists(int id)
        {
            return _context.Results.Any(e => e.ResultId == id);
        }
    }
}
