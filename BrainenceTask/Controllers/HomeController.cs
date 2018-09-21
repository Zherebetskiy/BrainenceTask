using Microsoft.AspNetCore.Mvc;
using BrainenceTask.BusinessLogic;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.IO;

namespace BrainenceTask.Controllers
{
    public class HomeController : Controller
    {
        readonly IWordBL wordBL;

        public HomeController(IWordBL wordBL)
        {
            this.wordBL = wordBL;
        }

        public IActionResult Index()
        {
            return View(wordBL.Get());
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile,[FromForm] string word)
        {
            var content = string.Empty;
            using (var reader = new StreamReader(uploadedFile.OpenReadStream()))
            {
                content = reader.ReadToEnd();
            }

            wordBL.Save(content,word);

            return RedirectToAction("Index");
        }

    }
}
