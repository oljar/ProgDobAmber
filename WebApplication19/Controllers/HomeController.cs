﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {


        
        public ActionResult ProductChoise()

        {
           ViewBag.Message = "Dobór Automatyczny - Wybór poduktu";

            
            return View();
        }


        public ActionResult TypChoiseAmber1()

        {
            ViewBag.Message = "Dobór Automatyczny - Amber 1 ";


            return View();
        }

        public ActionResult TypChoiseAmber2()

        {
            ViewBag.Message = "Dobór Automatyczny - Amber 2 ";


            return View();
        }

        public ActionResult TypChoiseAmberRoof()

        {
            ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wersja Dachowa";


            return View();
        }






        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kontakt()

        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Wykres()

        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Index(Parameters parameters)


        {


           

            int n = (int)parameters.Typoszereg + parameters.Wymiennik + parameters.Montaz + parameters.WydNom;    //  n odpowiada za wybór  centrali



            if (n == 4 || n == 14)                                                                          //  zmiana dla modeli 800
            {
                n = n + 1;
            }


            int a = parameters.Sprez;

            int b = parameters.Wydatek;

            

            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;

            return View("Wykres",parameters);
        }

    }

}





        