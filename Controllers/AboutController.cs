using Microsoft.AspNetCore.Mvc;

namespace First_Dot_Net_Project.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
