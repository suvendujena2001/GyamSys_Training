using Microsoft.AspNetCore.Mvc;


namespace File_Result.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public string Index()
        {
            return "home";
        }

        [Route("file-download")]
        public VirtualFileResult FileDown()
        {
            return new VirtualFileResult("/sample.pdf", "application/pdf");
        }

        [Route("file-download2")]
        public PhysicalFileResult FileDownload2()
        {
            //return new PhysicalFileResult(@"c:\aspnetcore\sample.pdf", "application/pdf");
            return PhysicalFile(@"c:\aspnetcore\sample.pdf", "application/pdf");
        }

        [Route("file-download3")]
        public FileContentResult FileDownload3()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"c:\aspnetcore\sample.pdf");
            //return new FileContentResult(bytes, "application/pdf");
            //byte array that is the raw data can be used while reading the bytes form images from the database
            //reading the images from the databases
            return File(bytes, "application/pdf");
        }
    }
}
