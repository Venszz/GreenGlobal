using Microsoft.AspNetCore.Mvc;

namespace NewsWave.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
