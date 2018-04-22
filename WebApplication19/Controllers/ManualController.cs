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

            string attention = "";

            bool Approve = false;


            int Size = parameters.WydNom;

         


            if (parameters.Wymiennik == 0 && parameters.Montaz == 0)   // dobór centrali A1 - K
            {


                if ((Size == 1) && (parameters.X * parameters.CA1K300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA1K500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA1K800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA1K1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMinK1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }

      


            if (parameters.Wymiennik == 0 && parameters.Montaz == 10)   // dobór centrali A1 - KP
            {


                if ((Size == 1) && (parameters.X * parameters.CA1KP300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA1KP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA1KP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA1KP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMinK1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }




            if (parameters.Wymiennik == 20 && parameters.Montaz == 0)   // dobór centrali A1 - P
            {


                if ((Size == 1) && (parameters.X * parameters.CA1P300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA1P500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA1P800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA1P1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }






            if (parameters.Wymiennik == 20 && parameters.Montaz == 10)   // dobór centrali A1 - PP
            {


                if ((Size == 1) && (parameters.X * parameters.CA1PP300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA1PP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA1PP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA1PP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }


            double ccc = (parameters.X * parameters.CA1PP1200(parameters.Wydatek));




            if (parameters.Wymiennik == 40 && parameters.Montaz == 0)   // dobór centrali A1 - O
            {


                if ((Size == 1) && (parameters.X * parameters.CA1O300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA1O500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA1O800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA1O1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }





            if (parameters.Wymiennik == 40 && parameters.Montaz == 10)   // dobór centrali A1 - OP
            {


                if ((Size == 1) && (parameters.X * parameters.CA1OP300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA1OP500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA1OP800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA1OP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }










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






            if (ModelState.IsValid)
            {
                 ViewBag.Message = "Dobór Ręczny - Amber 1" + attention;
                 return View("SelectionA1X");
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
            bool Approve = false;

          

            int Size = parameters.WydNom;  // Wilekość centrali

            


            if (parameters.Wymiennik == 20 && parameters.Montaz == 0)   // dobór centrali A1 - OP
            {


                if ((Size == 1) && (parameters.X * parameters.CA2P300(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin300) > 0) && (parameters.Wydatek - parameters.VMax300) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 2) && (parameters.X * parameters.CA2P500(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin500) > 0) && (parameters.Wydatek - parameters.VMax500) < 0)
                {

                    Approve = true;
                }


                else if ((Size == 3) && (parameters.X * parameters.CA2P800(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin800) > 0) && (parameters.Wydatek - parameters.VMax800) < 0)
                {

                    Approve = true;
                }

                else if ((Size == 4) && (parameters.X * parameters.CA2P1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }



                else
                {
                    Approve = false;
                }
            }





            int n = 100 + parameters.Wymiennik + parameters.Montaz + Size;    //  n odpowiada za wybór  centrali



            int a = parameters.Sprez;

            int b = parameters.Wydatek;




            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono";

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



            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Ręczny - Amber 2" + attention;
                return View("SelectionA2P");
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
            bool Approve = false;
            


            if (parameters.Wymiennik == 40 && parameters.Montaz == 0)   // dobór centrali A1 - OP
            {


                if ((Size == 4) && (parameters.X * parameters.CADOP1200(parameters.Wydatek) > parameters.Sprez) && ((parameters.Wydatek - parameters.Z * parameters.VMin1200) > 0) && (parameters.Wydatek - parameters.VMax1200) < 0)
                {

                    Approve = true;
                }

                else
                {
                    Approve = false;
                }

             
            }





            int n = 200 + parameters.Wymiennik + parameters.Montaz + Size;    //  n odpowiada za wybór  centrali


            if (parameters.Sprez > parameters.MaxSprez)
            {
                n = 0;
                attention = " - Spręż dyspozycyjny przekroczono";

            }


            int a = parameters.Sprez;

            int b = parameters.Wydatek;





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







            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dobór Ręczny- Amber 1 - Wer. Dachowa" + attention;
                return View("SelectionA1Roof");
            }
            else

            {
                ViewBag.Message = "Dobór Ręczny - Amber 1 - Wer. Dachowa - Popraw dane";
                return View();
            }



        }

        public ActionResult AhuData(Parameters parameters)


        {
            ViewBag.Message = "Paramerty centralki";



            int ni = (int)TempData["NI"];


            if ((bool)TempData["HeIn"] == true && ((bool)TempData["WoIn"] == false))
            {
                ViewBag.Name = parameters.ahu[ni].Name + parameters.SymHeIn;
                ViewBag.TotPowCons = parameters.ahu[ni].FanPow + parameters.ahu[ni].HePower + parameters.ahu[ni].RotPowCons;

            }

            else if ((bool)TempData["HeIn"] == false && ((bool)TempData["WoIn"] == false))
            {
                ViewBag.Name = parameters.ahu[ni].Name + parameters.SymHeOff;
                ViewBag.TotPowCons = parameters.ahu[ni].FanPow + parameters.ahu[ni].RotPowCons;


            }

            else if ((bool)TempData["HeIn"] == false && ((bool)TempData["WoIn"] == true))
            {
                ViewBag.Name = parameters.ahu[ni].Name + parameters.SymWoIn;
                ViewBag.TotPowCons = parameters.ahu[ni].FanPow + parameters.ahu[ni].RotPowCons;


            }


            ViewBag.Breadth = parameters.ahu[ni].Breadth;
            ViewBag.Height = parameters.ahu[ni].Height;
            ViewBag.Lenght = parameters.ahu[ni].Lenght;
            ViewBag.Diameter = parameters.ahu[ni].Diameter;
            ViewBag.Weight = parameters.ahu[ni].Weight;
            ViewBag.NomOut = parameters.ahu[ni].NomOut;
            ViewBag.ExtPres = parameters.ahu[ni].ExtPres;
            ViewBag.FanPow = parameters.ahu[ni].FanPow;
            ViewBag.HePower = parameters.ahu[ni].HePower;
            ViewBag.SupVol = parameters.ahu[ni].SupVol;
            ViewBag.Efficiency = parameters.ahu[ni].Efficiency;
            ViewBag.SoundLevel = parameters.ahu[ni].SoundLevel;
            ViewBag.PowClass = parameters.ahu[ni].PowClass;



            return View(parameters);

        }

    }




}