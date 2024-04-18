using BlogWebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogContext _blogContext;

        public BlogController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlog()
        {
            var blogs = await _blogContext.Blogs.ToListAsync();
            if (blogs == null)
            {
                return NotFound();
            }
            return blogs;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlog(int id)
        {
            var blog = await _blogContext.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return blog;
        }

        [HttpPost]
        public async Task<ActionResult<Blog>> PostBlog(Blog blog)
        {
            _blogContext.Blogs.Add(blog);
            await _blogContext.SaveChangesAsync();

            return CreatedAtAction("GetBlog", new { id = blog.Id }, blog);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlog(int id, Blog blog)
        {
            if (id != blog.Id)
            {
                return BadRequest();
            }

            _blogContext.Entry(blog).State = EntityState.Modified;

            try
            {
                await _blogContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogExists(id))
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

        private bool BlogExists(int id)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Blogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await _blogContext.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }

            _blogContext.Blogs.Remove(blog);
            await _blogContext.SaveChangesAsync();

            return NoContent();
        }


    }
}
