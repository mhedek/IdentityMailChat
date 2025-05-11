using Microsoft.AspNetCore.Mvc;

namespace IdentityCase.ViewComponents
{
    public class _SidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
