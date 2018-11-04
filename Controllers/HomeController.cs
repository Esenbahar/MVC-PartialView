using mvcintermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcintermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Veritabanına bağlanır ve bilgileri getirir
            //getirilen bilgiler bir model içerisine aktarılır
            //yani bir sınıf içerisine aktarılır. ve bu model view e gönderilir.

            //string[] Dersler = { "Matematik", " Veri yapıları", "Mobil programlama" };

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunId=1,UrunAdi="Samsung",Aciklama="orta",Fiyat=2000,Satistami=true},
                new Urun(){UrunId=1,UrunAdi="Huawei",Aciklama="orta",Fiyat=1000,Satistami=true},
                new Urun(){UrunId=1,UrunAdi="Iphone",Aciklama="orta",Fiyat=3000,Satistami=false},
                new Urun(){UrunId=1,UrunAdi="Nokıa",Aciklama="orta",Fiyat=2000,Satistami=false},
                new Urun(){UrunId=1,UrunAdi="Casper",Aciklama="orta",Fiyat=5000,Satistami=true},
                new Urun(){UrunId=1,UrunAdi="Iphone",Aciklama="orta",Fiyat=3000,Satistami=false},
                new Urun(){UrunId=1,UrunAdi="Nokıa",Aciklama="ortaortaortaortaortaortaortaortaortaortaortaortaortaortaortaortaortaortaortaortaorta",Fiyat=2000,Satistami=false},
                new Urun(){UrunId=1,UrunAdi="Casper",Aciklama="orta",Fiyat=5000,Satistami=true},
                new Urun(){UrunId=1,UrunAdi="Iphone",Aciklama="orta",Fiyat=3000,Satistami=false}
               
            };

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){KategoriId = 1, KategoriAdi ="Telefonlar"},
                new Kategori(){KategoriId = 2, KategoriAdi ="TV"},
                new Kategori(){KategoriId = 3, KategoriAdi ="Bilgisayar"}

            };



            UrunKategoriModel model = new UrunKategoriModel();
            model.Urunler = urunler;
            model.Kategoriler = kategoriler;
            model.UrunSayisi = urunler.Count();


            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;
            //ViewBag.KategoriSayisi = kategoriler.Count();

            return View(model);
        }
    }
}