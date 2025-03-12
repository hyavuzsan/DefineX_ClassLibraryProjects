
using AttributeMvcApp.Models;
using AttributeLibrary;
using System.Web.Mvc;

namespace AttributeMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(Ogrenci ogrenci)
        {
            // Eğer herhangi bir alan boşsa hata mesajı gösterelim
            if (string.IsNullOrEmpty(ogrenci.Adi) || string.IsNullOrEmpty(ogrenci.Soyadi) || string.IsNullOrEmpty(ogrenci.Bolum))
            {
                ViewBag.Mesaj = "Lütfen tüm alanları doldurun!";
                return View("Index");
            }

            // Eğer tüm alanlar doluysa doğrulamayı çalıştır
            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                ViewBag.Mesaj = "Öğrenci bilgileri doğrulamadan geçemedi!";
            }
            else
            {
                ViewBag.Mesaj = "Form başarılı!";
            }

            return View("Index");
        }
    }
}
