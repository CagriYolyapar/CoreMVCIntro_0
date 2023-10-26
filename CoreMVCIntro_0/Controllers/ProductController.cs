using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro_0.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AddProductPage()
        {
            return View();
        }
    }
}
