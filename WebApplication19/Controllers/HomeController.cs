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

                    parameters.DyspSpr = parameters.X * parameters.CA1K300(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1K500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model K500

                    parameters.DyspSpr = parameters.X * parameters.CA1K500(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1K800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model K800

                    parameters.DyspSpr = parameters.X * parameters.CA1K800(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1K1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 5; //  model K1200

                    parameters.DyspSpr = parameters.X * parameters.CA1K1200(parameters.Wydatek);

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

                    parameters.DyspSpr = parameters.X * parameters.CA1KP300(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1KP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model KP500

                    parameters.DyspSpr = parameters.X * parameters.CA1KP500(parameters.Wydatek);
                }

                else if ((parameters.X * parameters.CA1KP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model KP800

                    parameters.DyspSpr = parameters.X * parameters.CA1KP800(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1KP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 5; //  model KP1200

                    parameters.DyspSpr = parameters.X * parameters.CA1KP1200(parameters.Wydatek);
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
                    parameters.DyspSpr = parameters.X * parameters.CA1P300(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1P500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model P500

                    parameters.DyspSpr = parameters.X * parameters.CA1P500(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA1P800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model P800

                    parameters.DyspSpr = parameters.X * parameters.CA1P800(parameters.Wydatek);
                }

                else if ((parameters.X * parameters.CA1P1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 4; //  model P1200

                    parameters.DyspSpr = parameters.X * parameters.CA1P1200(parameters.Wydatek);
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

                            parameters.DyspSpr = parameters.X * parameters.CA1PP300(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1PP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                        {
                            WydNom = 2; //  model PP500

                            parameters.DyspSpr = parameters.X * parameters.CA1PP500(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1PP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                        {
                            WydNom = 3; //  model PP800

                            parameters.DyspSpr = parameters.X * parameters.CA1PP800(parameters.Wydatek);




                        }

                        else if ((parameters.X * parameters.CA1PP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                        {
                            WydNom = 4; //  model PP1200

                            parameters.DyspSpr = parameters.X * parameters.CA1PP1200(parameters.Wydatek);

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

                            parameters.DyspSpr = parameters.X * parameters.CA1O300(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1O500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                        {
                            WydNom = 2; //  model O500

                            parameters.DyspSpr = parameters.X * parameters.CA1O500(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1O800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                        {
                            WydNom = 3; //  model O800

                            parameters.DyspSpr = parameters.X * parameters.CA1O800(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1O1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                        {
                            WydNom = 4; //  model O1200

                            parameters.DyspSpr = parameters.X * parameters.CA1O1200(parameters.Wydatek);

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

                            parameters.DyspSpr = parameters.X * parameters.CA1OP300(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1OP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                        {
                            WydNom = 2; //  model OP500

                            parameters.DyspSpr = parameters.X * parameters.CA1OP500(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1OP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                        {
                            WydNom = 3; //  model OP800

                            parameters.DyspSpr = parameters.X * parameters.CA1OP800(parameters.Wydatek);

                        }

                        else if ((parameters.X * parameters.CA1OP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                        {
                            WydNom = 4; //  model OP1200

                            parameters.DyspSpr = parameters.X * parameters.CA1OP1200(parameters.Wydatek);

                        }





                        else
                        {
                            attention = " - Dopuszczalne parametry przekroczone";


                        }



                    }








           



           

                // Sprawdzenie zakresów - czy punkt pracy jest w zakresie wydatków 

                if ((WydNom == 1) && (parameters.Wydatek - parameters.Z * parameters.VMin300) > 0)
                {

                    Approve = true;
                }

                else if ((WydNom == 2) && (parameters.Wydatek - parameters.Z * parameters.VMin500) > 0)
                {
                    Approve = true;

                }

                else if ((WydNom == 3) && (parameters.Wydatek - parameters.Z * parameters.VMin800) > 0)
                {
                    Approve = true;

                }


                else if ((WydNom == 4) && (parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0)
                {
                     Approve = true;
                }


                else if ((WydNom == 5) && (parameters.Wydatek - parameters.Z * parameters.VMinK1200) > 0)
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




            for (int i = 0; i < parameters.ahu.Length; i++)  // ustalam wartość indexu  tablicy dla n
            {
                if (parameters.ahu[i].ID == n)
                {

                    ViewBag.Name = parameters.ahu[i].Name;

                    ViewBag.NI = i;  // Wartość indexu tablicy dla n

                    TempData["NI"] = i; // Wartość indexu tablicy dla n


                    break;

                }
               

            }




                    TempData["DyspSpr"] = parameters.DyspSpr;
                    ViewBag.Sprez = a;
                    ViewBag.Wydatek = b;
                    ViewBag.Centrala = n;
                    ViewBag.Approve = Approve;

                    ViewBag.Z = parameters.Z;


                    
                    ViewBag.VMax300 = parameters.VMax300;
                    ViewBag.VMax500 = parameters.VMax500;
                    ViewBag.VMax800 = parameters.VMax800;
                    ViewBag.VMax1200 = parameters.VMax1200;


                    ViewBag.VMin300 = parameters.VMin300;
                    ViewBag.VMin500 = parameters.VMin500;
                    ViewBag.VMin800 = parameters.VMin800;
                    ViewBag.VMin1200 = parameters.VMin1200;
                    ViewBag.VMinK1200 = parameters.VMinK1200;
                    ViewBag.HeIn = parameters.HeIn;
                    ViewBag.SymHeIn = parameters.SymHeIn;
                    ViewBag.SymHeOff = parameters.SymHeOff;

                    TempData["Sprez"] = a;
                    TempData["Wydatek"] = b;
                    TempData["HeIn"] = parameters.HeIn;
                    TempData["SymHeIn"] = parameters.HeIn;
                    TempData["SymHeOff"] = parameters.HeIn;
                    TempData["WoIn"] = false;
                    TempData["Bypass"] = 0;





            if (ModelState.IsValid)
                    {
                        ViewBag.Message = "Dobór Automatyczny - Amber 1" + attention;
                        return View("SelectionA1X");
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

                    parameters.DyspSpr = parameters.X * parameters.CA2P300(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA2P500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax500) < 0))
                {
                    WydNom = 2; //  model A2P500

                    parameters.DyspSpr = parameters.X * parameters.CA2P500(parameters.Wydatek);


                }

                else if ((parameters.X * parameters.CA2P800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax800) < 0))
                {
                    WydNom = 3; //  model A2P800

                    parameters.DyspSpr = parameters.X * parameters.CA2P800(parameters.Wydatek);

                }

                else if ((parameters.X * parameters.CA2P1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.VMax1200) < 0))


                {
                    WydNom = 4; //  model A2P800

                    parameters.DyspSpr = parameters.X * parameters.CA2P1200(parameters.Wydatek);

                }





                else
                {
                    attention = " - Dopuszczalne parametry przekroczone";


                }



            }







            // Sprawdzenie zakresów - czy punkt pracy jest w zakresie wydatków 

            if ((WydNom == 1) && (parameters.Wydatek - parameters.Z * parameters.VMin300) > 0)
            {

                Approve = true;
            }

            else if ((WydNom == 2) && (parameters.Wydatek - parameters.Z * parameters.VMin500) > 0)
            {
                Approve = true;

            }

            else if ((WydNom == 3) && (parameters.Wydatek - parameters.Z * parameters.VMin800) > 0)
            {
                Approve = true;

            }


            else if ((WydNom == 4) && (parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0)
            {
                Approve = true;
            }


            else if ((WydNom == 5) && (parameters.Wydatek - parameters.Z * parameters.VMinK1200) > 0)
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







            for (int i = 0; i < parameters.ahu.Length; i++)  // ustalam wartość indexu  tablicy dla n
            {
                if (parameters.ahu[i].ID == n)
                {

                    ViewBag.Name = parameters.ahu[i].Name;

                    ViewBag.NI = i;  // Wartość indexu tablicy dla n

                    TempData["NI"] = i; // Wartość indexu tablicy dla n


                    break;

                }
               

            }




            TempData["DyspSpr"] = parameters.DyspSpr;
            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;
            ViewBag.Approve = Approve;

            ViewBag.Z = parameters.Z;



            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax1200 = parameters.VMax1200;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin1200 = parameters.VMin1200;
            ViewBag.VMinK1200 = parameters.VMinK1200;
            ViewBag.HeIn = parameters.HeIn;
            ViewBag.SymHeIn = parameters.SymHeIn;
            ViewBag.SymHeOff = parameters.SymHeOff;


            TempData["Sprez"] = a;
            TempData["Wydatek"] = b;
            TempData["HeIn"] = parameters.HeIn;
            TempData["SymHeIn"] = parameters.HeIn;
            TempData["SymHeOff"] = parameters.HeIn;
            TempData["WoIn"] = false;
            TempData["Bypass"] = parameters.Bypass;


            if (parameters.Bypass == 1)

            {
                ViewBag.Bypass = "-B";
            }
            else if (parameters.Bypass == 2)
            {
                ViewBag.Bypass = "-0";
            }






            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 2" + attention;
                return View("SelectionA2P");
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

                    parameters.DyspSpr = parameters.X * parameters.CADOP1200(parameters.Wydatek);
                }

               





                else
                {
                    attention = " - Parametry przekroczone";


                }



            }


            // Sprawdzenie zakresów - czy punkt pracy jest w zakresie wydatków 


            if ((WydNom == 4) && (parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0)
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




            for (int i = 0; i < parameters.ahu.Length; i++)  // ustalam wartość indexu  tablicy dla n
            {
                if (parameters.ahu[i].ID == n)
                {

                    ViewBag.Name = parameters.ahu[i].Name;

                    ViewBag.NI = i;  // Wartość indexu tablicy dla n
                    TempData["NI"] = i; // Wartość indexu tablicy dla n




                    break;

                }
               

            }



            TempData["DyspSpr"] = parameters.DyspSpr;
            ViewBag.Sprez = a;
            ViewBag.Wydatek = b;
            ViewBag.Centrala = n;
            ViewBag.Approve = Approve;

            ViewBag.Z = parameters.Z;



            ViewBag.VMax300 = parameters.VMax300;
            ViewBag.VMax500 = parameters.VMax500;
            ViewBag.VMax800 = parameters.VMax800;
            ViewBag.VMax1200 = parameters.VMax1200;


            ViewBag.VMin300 = parameters.VMin300;
            ViewBag.VMin500 = parameters.VMin500;
            ViewBag.VMin800 = parameters.VMin800;
            ViewBag.VMin1200 = parameters.VMin1200;
            ViewBag.VMinK1200 = parameters.VMinK1200;
            ViewBag.WoIn = parameters.WoIn;
            ViewBag.SymWoIn = parameters.SymWoIn;
            ViewBag.SymWoOff = parameters.SymWoOff;

            TempData["Sprez"] = a;
            TempData["Wydatek"] = b;
            TempData["WoIn"] = parameters.WoIn;
            TempData["SymWoIn"] = parameters.SymWoIn;
            TempData["SymWoOff"] = parameters.SymWoOff;
            TempData["HeIn"] = false;
            TempData["Bypass"] = 0;














            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Automatyczny - Amber 1 - Wer. Dachowa" + attention;
                return View("SelectionA1Roof",parameters);
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



        public ActionResult LeftSide()

        {
            TempData["Side"] = 1;

            return RedirectToAction("AhuData","Home");
        }




        public ActionResult RightSide()

        {
            TempData["Side"] = 2;

            return RedirectToAction("AhuData", "Home");
        }



        public ActionResult WithoutSide()

        {
            TempData["Side"] = 0;
            return RedirectToAction("AhuData", "Home");

        }



        public ActionResult AhuData(Parameters parameters)



        {
            string Side ="";
            string Bypass = "";
            string Binfo = "Nie";


            ViewBag.Message = "Paramerty centralki";



            if ((int)TempData["Side"] == 1)
            {
                  Side= "-L";
            }
            else if ((int)TempData["Side"] == 2)
            {
                  Side = "-P";
            }



            if ((int)TempData["Bypass"] == 1)

            {
                Bypass = "-B";
                Binfo = "Tak";
            }
            else if ((int)TempData["Bypass"] == 2)
            {
                Bypass = "-0";
                Binfo = "Nie";
            }



            int ni = (int)TempData["NI"];


            if ((bool)TempData["HeIn"] == true && ((bool)TempData["WoIn"] == false))
            {
                ViewBag.Name = parameters.ahu[ni].Name + parameters.SymHeIn + Side + Bypass ;
                ViewBag.TotPowCons = parameters.ahu[ni].FanPow + parameters.ahu[ni].HePower + parameters.ahu[ni].RotPowCons;

            }

            else if ((bool)TempData["HeIn"] == false && ((bool)TempData["WoIn"] == false))
            {
                ViewBag.Name = parameters.ahu[ni].Name + parameters.SymHeOff + Side + Bypass;
                ViewBag.TotPowCons = parameters.ahu[ni].FanPow + parameters.ahu[ni].RotPowCons;


            }

            else if ((bool)TempData["HeIn"] == false && ((bool)TempData["WoIn"] == true))
            {
                ViewBag.Name = parameters.ahu[ni].Name + parameters.SymWoIn + Side + Bypass;
                ViewBag.TotPowCons = parameters.ahu[ni].FanPow + parameters.ahu[ni].RotPowCons;


            }


            ViewBag.Breadth = parameters.ahu[ni].Breadth;
            ViewBag.Height = parameters.ahu[ni].Height;
            ViewBag.Lenght = parameters.ahu[ni].Lenght;
            ViewBag.Diameter = parameters.ahu[ni].Diameter;
            ViewBag.Weight = parameters.ahu[ni].Weight;
            ViewBag.NomOut = TempData["Wydatek"];
            ViewBag.ExtPres = TempData["Sprez"];
            ViewBag.FanPow = parameters.ahu[ni].FanPow;
            ViewBag.HePower = parameters.ahu[ni].HePower;
            ViewBag.SupVol = parameters.ahu[ni].SupVol;      
            ViewBag.Efficiency = parameters.ahu[ni].Efficiency;
            ViewBag.SoundLevel = parameters.ahu[ni].SoundLevel; 
            ViewBag.PowClass = parameters.ahu[ni].PowClass;
            ViewBag.WoPower = parameters.ahu[ni].WoPower;
            
            ViewBag.DyspSpr = Math.Round((double)TempData["DyspSpr"], 0);
            ViewBag.Binfo = Binfo;




            return View(parameters);

        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception e = filterContext.Exception;
            //Log Exception e
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }

        public ActionResult Amber1()


        {
            ViewBag.Message = "Amber 1 - opis";


            return View();

        }


        public ActionResult Amber2()


        {
            ViewBag.Message = "Amber 2 - opis";


            return View();

        }

        public ActionResult Amber1DO()


        {
            ViewBag.Message = "Amber 1 wersja dachowa - opis";


            return View();

        }




        public ActionResult Krzyzowy()
       


        {
            ViewBag.Message = "Wymiennik krzyżowy - opis";


            return View();

        }




        public ActionResult Przeciwpradowy()



        {
            ViewBag.Message = "Wymiennik przeciwprądowy - opis";


            return View();

        }


        public ActionResult Obrotowy()


        {
            ViewBag.Message = "Wymiennik obrotowy - opis";


            return View();

        }




    }

}





        