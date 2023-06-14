using BookStore.Areas.Admin.ViewModel;
using Business.Abstract;
using Entities.Concrete;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace KutuphanePlatformu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
       private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("/")]
        public ActionResult Index(int? SayfaNo)
        {

            int _sayfaNo = SayfaNo ?? 1;
            var result = _categoryService.GetAll().OrderByDescending(x=>x.ID).ToPagedList<Category>(_sayfaNo,5);
            return View(result);
        }

        /*

        [HttpGet]
        public ActionResult Yeni()
        {
            return View("KategoriForm", new Category());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Category kategori)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriForm");
            }

            MessageViewModel mesajViewModel = new MessageViewModel();

            if (kategori.Id == 0)
            {
               var kategoriAd = c.Categories.ToList();
                foreach (var item in kategoriAd)
                {
                    if (kategori.KategoriAdi == item.KategoriAdi)
                    {
                        mesajViewModel.Status = false;
                        mesajViewModel.LinkText = "Kategori Listesi";
                        mesajViewModel.Url = "/Admin/Kategori";
                        mesajViewModel.Mesaj = "Bu kategori zaten mevcut...";
                        TempData["mesaj"] = mesajViewModel;

                        return View("KategoriForm");
                    }
                }
                c.Categories.Add(kategori);
                mesajViewModel.Mesaj = kategori.KategoriAdi + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekKategori = c.Categories.Find(kategori.Id);
                if (guncellenecekKategori == null)
                {
                    return HttpNotFound();
                }
                var eskiKategoriAd = guncellenecekKategori.KategoriAdi;

                if (kategori.KategoriAdi == eskiKategoriAd)
                {
                    mesajViewModel.Status = false;
                    mesajViewModel.LinkText = "Kategori Listesi";
                    mesajViewModel.Url = "/Admin/Kategori";
                    mesajViewModel.Mesaj = "Herhangi bir değişiklik yapılmadı...";
                    TempData["mesaj"] = mesajViewModel;
                    return View("KategoriForm");

                }
                else
                {

                    guncellenecekKategori.KategoriAdi = kategori.KategoriAdi;
                    mesajViewModel.Mesaj = eskiKategoriAd + " => " + kategori.KategoriAdi + " olarak başarıyla güncellendi...";

                }
            }
            c.SaveChanges();
            mesajViewModel.Status = true;
            TempData["mesaj"] = mesajViewModel;
            return RedirectToAction("Index", "Kategori");
        }

        public ActionResult Guncelle(int id)
        {
            var model = c.Categories.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("KategoriForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekKategori = c.Categories.Find(id);
            if (silinecekKategori == null)
                return HttpNotFound();
            c.Categories.Remove(silinecekKategori);
            c.SaveChanges();
            return RedirectToAction("Index", "Kategori");

        }


        */

    }
}