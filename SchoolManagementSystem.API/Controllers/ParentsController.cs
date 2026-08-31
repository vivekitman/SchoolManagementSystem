using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.API.Controllers
{
    public class ParentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
