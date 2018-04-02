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
                    goto Exit;
                }


            }



            else if (parameters.Wymiennik == 0 && parameters.Montaz == 10)   // dobór centrali A1 - KP
            {


                if (parameters.X * parameters.CA1KP300(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 1; //  model KP300
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1KP500(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 2; //  model KP500
                    goto Exit;
                }


                else if (parameters.X * parameters.CA1KP800(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 3; //  model KP800
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1KP1200(parameters.Wydatek) > parameters.Sprez)
                {

                    WydNom = 4; //  model KP1200
                    goto Exit;
                }


                else
                {
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                    goto Exit;
                }




            }
            


            else if (parameters.Wymiennik == 20 && parameters.Montaz == 0)   // dobór centrali A1 - P
            {

                if (parameters.X * parameters.CA1P300(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 1; //  model KP300
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1P500(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 2; //  model KP500
                    goto Exit;
                }


                else if (parameters.X * parameters.CA1P800(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 3; //  model KP800
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1P1200(parameters.Wydatek) > parameters.Sprez)
                {

                    WydNom = 4; //  model KP1200
                    goto Exit;
                }


                else
                {
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                    goto Exit;
                }

            }



            else if (parameters.Wymiennik == 20 && parameters.Montaz == 10)   // dobór centrali A1 - PP
            {

                if (parameters.X * parameters.CA1PP300(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 1; //  model PP300
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1PP500(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 2; //  model PP500
                    goto Exit;
                }


                else if (parameters.X * parameters.CA1PP800(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 3; //  model PP800
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1PP1200(parameters.Wydatek) > parameters.Sprez)
                {

                    WydNom = 4; //  model PP1200
                    goto Exit;
                }

                else
                {
                    
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                    goto Exit;


                }
            }

            else if (parameters.Wymiennik == 40 && parameters.Montaz == 0)   // dobór centrali A1 - O
            {

                if (parameters.X * parameters.CA1O300(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 1; //  model O300
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1O500(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 2; //  model O500
                    goto Exit;
                }


                else if (parameters.X * parameters.CA1O800(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 3; //  model O800
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1O1200(parameters.Wydatek) > parameters.Sprez)
                {

                    WydNom = 4; //  model O1200
                    goto Exit;
                }

                else
                {
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                    goto Exit;

                }


            }


            else if (parameters.Wymiennik == 40 && parameters.Montaz == 10)   // dobór centrali A1 - OP
            {

                if (parameters.X * parameters.CA1OP300(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 1; //  model OP300
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1OP500(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 2; //  model OP500
                    goto Exit;
                }


                else if (parameters.X * parameters.CA1OP800(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 3; //  model OP800
                    goto Exit;
                }

                else if (parameters.X * parameters.CA1OP1200(parameters.Wydatek) > parameters.Sprez)
                {

                    WydNom = 4; //  model OP1200
                    goto Exit;
                }

                else
                {
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                    goto Exit;

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
            int WydNom = 0;
            string attention = "";



            if (parameters.MaxSprez < parameters.Sprez)         // Zabezpieczenie Spręż za duży

            {
                WydNom = 1000000;
                attention = " - Zbyt wysoki spręż ";
                goto Exit;

            }




            if (parameters.Wymiennik == 20 && parameters.Montaz == 0)   // dobór centrali A2

            {

                if (parameters.X * parameters.CA2P300(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 1; //  model A2-P300
                    goto Exit;
                }

                else if (parameters.X * parameters.CA2P500(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 2; //  model A2-P500
                    goto Exit;
                }


                else if (parameters.X * parameters.CA2P800(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 3; //  model A2-P800
                    goto Exit;
                }

                else if (parameters.X * parameters.CA2P1200(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 4; //  model A2-P1200
                    goto Exit;
                }


                else

                {
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                }
            }

            


            Exit:



            int n = 100 + parameters.Wymiennik + parameters.Montaz + WydNom;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;



            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;










            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 2" + attention;
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
            int WydNom = 0;
            string attention = "";



            if (parameters.MaxSprez < parameters.Sprez)         // Zabezpieczenie Spręż za duży

            {
                WydNom = 1000000;
                attention = " - Zbyt wysoki spręż ";
                goto Exit;

            }




            if (parameters.Wymiennik == 40 && parameters.Montaz == 0)   // dobór centrali A1 O-1200 Wersja Dachowa

            {

                if (parameters.X * parameters.CADOP1200(parameters.Wydatek) > parameters.Sprez)
                {
                    WydNom = 4; //  model A1-O-1200 Wersja Dachowa
                    goto Exit;
                }
                
                else

                {
                    WydNom = 1000000;     // Zabezpieczenie param za duże
                    attention = " - Zbyt wysoke parametry ";
                }
            }




            Exit:



            int n = 200 + parameters.Wymiennik + parameters.Montaz + WydNom;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;



            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;










            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 O -1200 - Wersja Dachowa" + attention;
                return View("Wykres", parameters);
            }
            else

            {
                ViewBag.Message = "Dobór Automatyczny - Amber 2 - Popraw dane";
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





        