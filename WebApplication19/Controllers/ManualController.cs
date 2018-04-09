using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class ManualController : Controller
    {
        public ActionResult ProductChoiseManual()

        {
            ViewBag.Message = "Dobór Ręczny - Wybór poduktu";



            return View();

        }


         public ActionResult TypChoiseAmber1Manual()
        {
            ViewBag.Message = "Dobór Ręczny - Amber 1 ";
            return View();
        }





        [HttpPost]
        public ActionResult TypChoiseAmber1Manual(Parameters parameters)


        {
           
            string attention="";











            int Size = parameters.WydNom;  // Wilekość centrali



            int n = 0 + parameters.Wymiennik + parameters.Montaz + Size;    //  n odpowiada za wybór  centrali

            if (n == 4 || n == 14)                                                 //  zmiana dla modeli K-1200
            {
                n = n + 1;
            }

            int a = parameters.Sprez;

            int b = parameters.Wydatek;





            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono ";

            }


            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;


            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax800 = parameters.VMax800;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMinK1200 = parameters.VMinK1200;




            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Ręczny - Amber 1" + attention;
                return View("Selection");
            }
            else

            {
                ViewBag.Message = "Dobór Ręczny - Amber 1 - Popraw dane";
                return View();
            }




        }






        public ActionResult TypChoiseAmber2Manual()
        {
            ViewBag.Message = "Dobór Ręczny - Amber 2 ";
            return View();
        }




        [HttpPost]
        public ActionResult TypChoiseAmber2Manual(Parameters parameters)


        {
            
            string attention = "";


            int Size = parameters.WydNom;  // Wilekość centrali





            int n = 100 + parameters.Wymiennik + parameters.Montaz + Size;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;




            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono";

            }



            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;



            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax800 = parameters.VMax800;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMinK1200 = parameters.VMinK1200;






            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Ręczny - Amber 2" + attention;
                return View("Selection");
            }
            else

            {
                ViewBag.Message = "Dobór Ręczny - Amber 2 - Popraw dane";
                return View();
            }

        }







        public ActionResult TypChoiseAmberRoofManual()
        {
            ViewBag.Message = "Dobór Ręczny - Amber 1 - Wersja Dachowa";
            return View();


        }




        [HttpPost]
        public ActionResult TypChoiseAmberRoofManual(Parameters parameters)


        {
           
            string attention = "";
            int Size = parameters.WydNom;


            int n = 200 + parameters.Wymiennik + parameters.Montaz + Size;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;




            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono";

            }




            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;


            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax800 = parameters.VMax800;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMinK1200 = parameters.VMinK1200;







            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Ręczny- Amber 1 - Wer. Dachowa" + attention;
                return View("Selection");
            }
            else

            {
                ViewBag.Message = "Dobór Ręczny - Amber 1 - Wer. Dachowa - Popraw dane";
                return View();
            }

        }



    }




}