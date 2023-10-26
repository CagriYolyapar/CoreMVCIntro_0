using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro_0.Controllers
{
    public class HomeController : Controller
    {
        //MVC'de Controller icerisinde olan metotlara biz Action deriz...

        //MVC'de Action'lar cok önemlidir......Cünkü BackEnd işlemlerinizi, HTTP'ye göre görev yapmak isteidiginiz tüm işlemlerinizi Controller'daki Action'lar yapar...

        //Eger MVC'de bir Action'a HTTP request tipi vermezseniz, Action otomatik olarak HTTPGet yönteminde calısır...

        //MVC'de url'e yazdıgınız controller yoksa veya controller varsa ama icerisindeki action yoksa aynı hatayı alırsınız

        //MVC'de projenizin sayfayı size getirebilmesi icin sadece Controller ve Action yetmez...Action'in döndürecegi bir View olması gerekir...Yani bir sayfa olması gerekir...


        public IActionResult Index()
        {
            //View metodu hangi Action icerisinde cagrılıyor ise o eger argümanı yoksa icinde bulundugu Action isminde bir View'i mimarinizin Views klasorunde sahip olduğu Controller klasorunun icerisinde arayacaktır... Yani icinde bulundugu Action ile aynı isme sahip olan bir View'i döndürmeye calısır...
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //Home/Contact
    }
}
