using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro_0.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult AddCategoryPage()
        {
            return View();
        }

        public IActionResult UpdateCategoryPage()
        {
            return View();
        }


       
    }
}
