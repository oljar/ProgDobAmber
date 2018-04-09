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
            int WydNom = 0;
            string attention = "";
            bool Approve = false;








            if (parameters.Wymiennik == 0 && parameters.Montaz == 0)   // dobór centrali A1 - K



            {



                if ((parameters.X * parameters.CA1K300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                {
                    WydNom = 1; //  model K300

                }

                else if ((parameters.X * parameters.CA1K500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model K500

                }

                else if ((parameters.X * parameters.CA1K800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model K800

                }

                else if ((parameters.X * parameters.CA1K1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 5; //  model K1200

                }





                else
                {
                    attention = " - Dopuszczalne parametry przekroczone";


                }



            }








            if (parameters.Wymiennik == 0 && parameters.Montaz == 10)   // dobór centrali A1 - KP



            {



                if ((parameters.X * parameters.CA1KP300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                {
                    WydNom = 1; //  model KP300

                }

                else if ((parameters.X * parameters.CA1KP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model KP500

                }

                else if ((parameters.X * parameters.CA1KP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model KP800

                }

                else if ((parameters.X * parameters.CA1KP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 5; //  model KP1200

                }





                else
                {
                    attention = " - Dopuszczalne parametry przekroczone";


                }
            }





            if (parameters.Wymiennik == 20 && parameters.Montaz == 0)   // dobór centrali A1 - P



            {



                if ((parameters.X * parameters.CA1P300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                {
                    WydNom = 1; //  model P300

                }

                else if ((parameters.X * parameters.CA1P500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model P500

                }

                else if ((parameters.X * parameters.CA1P800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model P800

                }

                else if ((parameters.X * parameters.CA1P1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 4; //  model P1200

                }





                else
                {
                    attention = " - Dopuszczalne parametry przekroczone";


                }





            }











            if (parameters.Wymiennik == 20 && parameters.Montaz == 10)   // dobór centrali A1 - PP



                    {



                        if ((parameters.X * parameters.CA1PP300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                        {
                            WydNom = 1; //  model PP300

                        }

                        else if ((parameters.X * parameters.CA1PP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                        {
                            WydNom = 2; //  model PP500

                        }

                        else if ((parameters.X * parameters.CA1PP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                        {
                            WydNom = 3; //  model PP800

                        }

                        else if ((parameters.X * parameters.CA1PP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                        {
                            WydNom = 4; //  model PP1200

                        }





                        else
                        {
                            attention = " - Dopuszczalne parametry przekroczone";


                        }



                    }







                    if (parameters.Wymiennik == 40 && parameters.Montaz == 0)   // dobór centrali A1 - O



                    {



                        if ((parameters.X * parameters.CA1O300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                        {
                            WydNom = 1; //  model O300

                        }

                        else if ((parameters.X * parameters.CA1O500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                        {
                            WydNom = 2; //  model O500

                        }

                        else if ((parameters.X * parameters.CA1O800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                        {
                            WydNom = 3; //  model O800

                        }

                        else if ((parameters.X * parameters.CA1O1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                        {
                            WydNom = 4; //  model O1200

                        }





                        else
                        {
                            attention = " - Dopuszczalne parametry przekroczone";


                        }



                    }






                    if (parameters.Wymiennik == 40 && parameters.Montaz == 10)   // dobór centrali A1 - OP



                    {



                        if ((parameters.X * parameters.CA1OP300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                        {
                            WydNom = 1; //  model OP300

                        }

                        else if ((parameters.X * parameters.CA1OP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                        {
                            WydNom = 2; //  model OP500

                        }

                        else if ((parameters.X * parameters.CA1OP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                        {
                            WydNom = 3; //  model OP800

                        }

                        else if ((parameters.X * parameters.CA1OP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                        {
                            WydNom = 4; //  model OP1200

                        }





                        else
                        {
                            attention = " - Dopuszczalne parametry przekroczone";


                        }



                    }








           



           

                // Sprawdzenie zakresów - czy punkt pracy jest w zakresie wydatków 

                if ((WydNom == 1) && (parameters.Wydatek - parameters.VMin300) > 0)
                {

                    Approve = true;
                }

                else if ((WydNom == 2) && (parameters.Wydatek - parameters.VMin500) > 0)
                {
                    Approve = true;

                }

                else if ((WydNom == 3) && (parameters.Wydatek - parameters.VMin800) > 0)
                {
                    Approve = true;

                }


                else if ((WydNom == 4) && (parameters.Wydatek - parameters.VMin1200) > 0)
                {
                Approve = true;
                }




                else if ((WydNom == 5) && (parameters.Wydatek - parameters.VMinK1200) > 0)

                {
                    Approve = true;

                }

                else
                {
                    Approve = false;

                }






            int n = 0 + parameters.Wymiennik + parameters.Montaz + WydNom;    //  n odpowiada za wybór  centrali

                    int a = parameters.Sprez;

                    int b = parameters.Wydatek;





                    if (parameters.Sprez > parameters.MaxSprez)
                    {
                        n = 0;
                        attention = " - Spręż dyspozycyjny przekroczono ";
                        Approve = false;
                    }


                    ViewBag.Sprez = a;
                    ViewBag.Wydatek = b;
                    ViewBag.Centrala = n;
                    ViewBag.Approve = Approve;



                    ViewBag.VMax300 = parameters.VMax300;
                    ViewBag.VMax500 = parameters.VMax500;
                    ViewBag.VMax800 = parameters.VMax800;
                    ViewBag.VMax1200 = parameters.VMax1200;


                    ViewBag.VMin300 = parameters.VMin300;
                    ViewBag.VMin500 = parameters.VMin500;
                    ViewBag.VMin800 = parameters.VMin800;
                    ViewBag.VMin1200 = parameters.VMin1200;
                    ViewBag.VMinK1200 = parameters.VMinK1200;





                    if (ModelState.IsValid)
                    {
                        ViewBag.Message = "Dobór Automatyczny - Amber 1" + attention;
                        return View("Selection");
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
            bool Approve = false;





            if (parameters.Wymiennik == 20 && parameters.Montaz == 0)   // dobór centrali A2- P



            {



                if ((parameters.X * parameters.CA2P300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax300) < 0))
                {
                    WydNom = 1; //  model A2P300

                }

                else if ((parameters.X * parameters.CA2P500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model A2P500

                }

                else if ((parameters.X * parameters.CA2P800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model A2P800

                }

                else if ((parameters.X * parameters.CA2P1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 4; //  model A2P800

                }





                else
                {
                    attention = " - Dopuszczalne parametry przekroczone";


                }



            }







            // Sprawdzenie zakresów - czy punkt pracy jest w zakresie wydatków 

            if ((WydNom == 1) && (parameters.Wydatek - parameters.VMin300) > 0)
            {

                Approve = true;
            }

            else if ((WydNom == 2) && (parameters.Wydatek - parameters.VMin500) > 0)
            {
                Approve = true;

            }

            else if ((WydNom == 3) && (parameters.Wydatek - parameters.VMin800) > 0)
            {
                Approve = true;

            }


            else if ((WydNom == 4) && (parameters.Wydatek - parameters.VMin1200) > 0)
            {
                Approve = true;
            }



            else
            {
                Approve = false;

            }












            int n = 100 + parameters.Wymiennik + parameters.Montaz + WydNom;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;




            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono";
                Approve = false;

            }



            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;
            ViewBag.Approve = Approve;



            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax1200 = parameters.VMax1200;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin1200 = parameters.VMin1200;
            ViewBag.VMinK1200 = parameters.VMinK1200;






            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 2" + attention;
                return View("Selection");
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
            bool Approve = false;





            if (parameters.Wymiennik == 40 && parameters.Montaz == 0)   // dobór centrali A1 Wersja Dachowa



            {



                if ((parameters.X * parameters.CADOP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))
                {
                    WydNom = 4; //  model A1DO1200

                }

               





                else
                {
                    attention = " - Parametry przekroczone";


                }



            }


            // Sprawdzenie zakresów - czy punkt pracy jest w zakresie wydatków 


            if ((WydNom == 4) && (parameters.Wydatek - parameters.VMin1200) > 0)
            {
                Approve = true;
            }


            else
            {
                Approve = false;

            }

             


            int n = 200 + parameters.Wymiennik + parameters.Montaz + WydNom;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;




            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono";
                Approve = false;

            }




            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;
            ViewBag.Approve = Approve;


            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax1200 = parameters.VMax1200;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin1200 = parameters.VMin1200;
            ViewBag.VMinK1200 = parameters.VMinK1200;







            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wer. Dachowa" + attention;
                return View("Selection");
            }
            else

            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wer. Dachowa - Popraw dane";
                return View();
            }

        }








        public ActionResult Kontakt()

        {
            ViewBag.Message = "Kontakt";

            return View();
        }

      

      

    }

}





        