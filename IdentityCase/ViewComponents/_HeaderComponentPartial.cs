using Microsoft.AspNetCore.Mvc;

namespace IdentityCase.ViewComponents
{
    public class _HeaderComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
