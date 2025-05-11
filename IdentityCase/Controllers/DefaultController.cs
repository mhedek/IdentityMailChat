using Microsoft.AspNetCore.Mvc;

namespace IdentityCase.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
