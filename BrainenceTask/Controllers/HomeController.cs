using Microsoft.AspNetCore.Mvc;
using BrainenceTask.BusinessLogic;

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
    }
}
