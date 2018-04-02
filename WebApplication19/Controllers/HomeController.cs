using System;
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





        [HttpPost]
        public ActionResult TypChoiseAmber1(Parameters parameters)

            
        {
            int WydNom=0;
            string attention = "";



            if (parameters.MaxSprez < parameters.Sprez)         // Zabezpieczenie Spręż za duży

            {
                WydNom = 1000000;  
                attention = " - Zbyt wysoki spręż ";
                goto Exit;

            }




                if (parameters.Wymiennik == 0 && parameters.Montaz == 0)   // dobór centrali A1 - K

                {

                    if (parameters.X * parameters.CA1K300(parameters.Wydatek) > parameters.Sprez)
                    {
                        WydNom = 1; //  model K300
                        goto Exit;
                    }

                    else if (parameters.X * parameters.CA1K500(parameters.Wydatek) > parameters.Sprez)
                    {
                        WydNom = 2; //  model K500
                        goto Exit;
                    }


                    else if (parameters.X * parameters.CA1K800(parameters.Wydatek) > parameters.Sprez)
                    {
                        WydNom = 3; //  model K800
                        goto Exit;
                    }

                    else if (parameters.X * parameters.CA1K1200(parameters.Wydatek) > parameters.Sprez)
                    {
                        WydNom = 4; //  model K1200
                        goto Exit;
                    }


                    else

                    {
                        WydNom = 1000000;     // Zabezpieczenie param za duże
                        attention = " - Zbyt wysoke parametry ";
                    }
                }


          







        Exit:



             int n = 0 + parameters.Wymiennik + parameters.Montaz + WydNom;    //  n odpowiada za wybór  centrali



            if (n == 4 || n == 14)                                                                          //  zmiana dla modeli 800
            {
                n = n + 1;
            }


            int a = parameters.Sprez;

            int b = parameters.Wydatek;

           

            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;


            
           






            if (ModelState.IsValid)
            {
                ViewBag.Message ="Dobór Automatyczny - Amber 1" + attention;
                return View("Wykres", parameters);
            }
            else

            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 - Popraw dane";
                return View();
            }

        }












        public ActionResult TypChoiseAmber2()
        {
            ViewBag.Message = "Dobór Automatyczny - Amber 2 ";
            return View();
        }





        [HttpPost]
        public ActionResult TypChoiseAmber2(Parameters parameters)


        {


            int Nominal= 1;
            int n = 100 + parameters.Wymiennik + parameters.Montaz + Nominal;    //  n odpowiada za wybór  centrali



        


            int a = parameters.Sprez;

            int b = parameters.Wydatek;



            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;








            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 2 ";
                return View("Wykres", parameters);
            }
            else

            {
                ViewBag.Message = "Dobór Automatyczny - Amber 2 - Popraw dane";
                return View();
            }

        }





        public ActionResult TypChoiseAmberRoof()
        {
            ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wersja Dachowa";
            return View();
        }





        [HttpPost]
        public ActionResult TypChoiseAmberRoof(Parameters parameters)


        {

            int Nominal = 4;

            int n = 200 + parameters.Wymiennik + parameters.Montaz + Nominal;    //  n odpowiada za wybór  centrali



            if (n == 4 || n == 14)                                                                          //  zmiana dla modeli 800
            {
                n = n + 1;
            }


            int a = parameters.Sprez;

            int b = parameters.Wydatek;



            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;








            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wersja Dachowa";
                return View("Wykres", parameters);
            }
            else

            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wersja Dachowa  POPRAW DANE ";
                return View();
            }

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





        