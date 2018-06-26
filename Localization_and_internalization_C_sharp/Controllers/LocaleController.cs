using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Localization_and_internalization_C_sharp.Controllers
{
    public class LocaleController : Controller
    {
        // GET: Locale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Change(string id)
        {
            CultureInfo ci = new CultureInfo(id);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            //Number Format

            int n = 12345678;
            ViewBag.NumberFormat = n.ToString("N", Thread.CurrentThread.CurrentCulture);

            //Percent Format
            double percent = 12.34;
            ViewBag.PercentFormat = percent.ToString("P", Thread.CurrentThread.CurrentCulture);

            //Currency Format
            int currency = 123456;
            ViewBag.CurrencyFormat = currency.ToString("C", Thread.CurrentThread.CurrentCulture);


            //Date Time Format
            ViewBag.DateTimeFormat = DateTime.Now.ToString("D", Thread.CurrentThread.CurrentCulture);

            //Content Format
            ViewBag.ContentFormat = Resources.Content.Message;

            return View("Index");

            
        }
    }
}