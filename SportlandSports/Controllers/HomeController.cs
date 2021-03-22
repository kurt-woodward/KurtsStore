using Microsoft.AspNetCore.Mvc;

namespace SportlandSports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

    }
}
