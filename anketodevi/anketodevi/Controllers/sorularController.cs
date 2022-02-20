using anketodevi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace anketodevi.Controllers
{
    public class sorularController : Controller
    {
  
        [HttpGet]
        public ActionResult sorular()
        {
            kayıtlıanketlistesi kayıt = new kayıtlıanketlistesi();
            Anketlistesi model = new Anketlistesi();
            Anket model1 = new Anket();
            model1.sorulist = new List<Soru> {
                new Soru{Id=0, Tanim="Edremit'in sevdiğiniz yemeklerini seçin",icerik="Balıkesir Kaymaklısı "},
                new Soru{Id=1,Tanim="Edremit'in sevdiğiniz yemeklerini seçin",icerik="Börülce "},
                new Soru{Id=2,Tanim="Edremit'in sevdiğiniz yemeklerini seçin",icerik="zeytinyağlı "},
                new Soru{Id=3,Tanim="Edremit'in sevdiğiniz yemeklerini seçin",icerik="Karanfilli ekmek "}

            };
            Anket model2 = new Anket();
            model2.sorulist = new List<Soru> {
                new Soru{Id=4, Tanim="Edremit'in en sevdiğiniz yerleri",icerik="Şahinderesi Kanyonu "},
                new Soru{Id=5,Tanim="Edremit'in en sevdiğiniz yerleri",icerik="Antandros Antik Kenti "},
                new Soru{Id=6,Tanim="Edremit'in en sevdiğiniz yerleri",icerik="Sarıkız Tepesi "},
                new Soru{Id=7,Tanim="Edremit'in en sevdiğiniz yerleri",icerik="Zeus Altarı "}

            };
            Anket model3 = new Anket();
            model3.sorulist = new List<Soru> {
                new Soru{Id=8, Tanim="Edremit'in sevdiğiniz kafeleri",icerik="limonlu bahçe "},
                new Soru{Id=9,Tanim="Edremit'in sevdiğiniz kafeleri",icerik="teras kafe "},
                new Soru{Id=10,Tanim="Edremit'in sevdiğiniz kafeleri",icerik="sarmaşık kafe "},
                new Soru{Id=11,Tanim="Edremit'in sevdiğiniz kafeleri",icerik="istasyon kafe "}

            };
            Anket model4 = new Anket();
            model4.sorulist = new List<Soru> {
                new Soru{Id=12, Tanim="Edremit'in sevdiğiniz parkları",icerik="Faruk Serpil Parkı"},
                new Soru{Id=13,Tanim="Edremit'in sevdiğiniz parkları",icerik="Edremit Şehitleri Parkı"},
                new Soru{Id=14,Tanim="Edremit'in sevdiğiniz parkları",icerik="Cumhuriyet Parkı"},
                new Soru{Id=15,Tanim="Edremit'in sevdiğiniz parkları",icerik="Ucgen Park"}

            };
            Anket model5 = new Anket();
            model5.sorulist = new List<Soru> {
                new Soru{Id=16, Tanim="Edremit'in ile ilgili bir söz"}
            };
            model.Anketlist = new List<Anket>
            {
                new Anket{SoruId=0,sorulist=model1.sorulist },
                new Anket{SoruId=1,sorulist=model2.sorulist },
                new Anket{SoruId=2,sorulist=model3.sorulist },
                new Anket{SoruId=3,sorulist=model4.sorulist },
                new Anket{SoruId=4,sorulist=model5.sorulist }
            };
            kayıt.Anketlisteleri = new List<Anketlistesi>
            {
                new Anketlistesi{AnketId=0,Anketlist=model.Anketlist}
            };
            
            return View(kayıt);

        }

        [HttpPost]
        public ActionResult sonuclar(kayıtlıanketlistesi model)
        {
            model.Anketlisteleri[0].Anketlist[4].sorulist[0].secildimi= true;
            List<Anketlistesi> anketler = model.Anketlisteleri.ToList();
            return View(anketler);
            
        }
        [HttpGet]
        public ActionResult yenisorular(kayıtlıanketlistesi model)
        {
            kayıtlıanketlistesi kayıt = new kayıtlıanketlistesi();
            
            return View();
        }
        [HttpPost]
        public ActionResult yenisonuclar(kayıtlıanketlistesi model)
        {
            kayıtlıanketlistesi kayıt = new kayıtlıanketlistesi();
            return View();
        }


    }
}