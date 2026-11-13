using Microsoft.AspNetCore.Mvc;

namespace First_Dot_Net_Project.Controllers
{
    public class UserController : Controller
    {
    
        //[Route("User/About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
