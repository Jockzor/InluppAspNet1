using Microsoft.AspNetCore.Mvc;

namespace InluppASP_NET1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
