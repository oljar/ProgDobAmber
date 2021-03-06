﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace WebApplication19.Models
{
    public class Parameters
    {
        [Required(ErrorMessage = "Proszę podać wartość liczbową w [m3/h] ")]
        public int Wydatek { get; set; }

        [Required(ErrorMessage = "Proszę podać wartość liczbową w [Pa] ")]
        public int Sprez { get; set; }

        public double DyspSpr { get; set; }

        public int Centrala { get; set; }


        public TypList Typoszereg { get; set; }

        public int Wymiennik { get; set; }


        [Required(ErrorMessage = "Proszę podać wartość liczbową w [m3/h] ")]
        public int WydNom { get; set; }

        public bool Approve { get; set; }

        public int Montaz { get; set; }

        [Required(ErrorMessage = "Proszę podać czy centrala ma posiadać narzewnicę elektryczną wtórną wbudowaną ")]
        public bool HeIn { get; set; }

        [Required(ErrorMessage = "Proszę podać czy centrala ma posiadać narzewnicę wodną wtórną wbudowaną ")]
        public bool WoIn { get; set; }

        [Required(ErrorMessage = "Proszę podać czy centrala ma posiadać wbudowany Bypass ")]
        public int Bypass { get; set; }

        public double X = 1;  // współczynnik bezpieczeństwa

        public double Z = 0.8; // Współczynnik zmniejszenie minimalnego wydatku - poprawia dobór automatyczny



        public int MaxSprez = 440;  // Dop spręż

        public int VMax300 = 500; // Dop wydatek dla 300
        public int VMax500 = 650;  // Dop wydatek dla 500
        public int VMax800 = 1050;  // Dop wydatek dla 800
        public int VMax1200 = 1600;  // Dop wydatek dla 1200


        public int VMin300 = 180;  //Min wydatek dla 300
        public int VMin500 = 350;   //Min wydatek dla 500
        public int VMin800 = 530;   //Min wydatek dla 800
        public int VMin1200 = 900;  //Min wydatek dla 1200
        public int VMinK1200 = 800;  //Min wydatek dla K1200

        public string SymHeIn = "-1"; // symbol z nagrzewnicą   elektryczną 

        public string SymHeOff = "-0";// symbol bez nagrzewnicy  elektrycznej

        public string SymWoIn = "-W";//symbol z nagrzewnicą elektryczną

        public string SymWoOff = "-0";//symbol z nagrzewnicą elektryczną



        public int NI;


        public AHU[] ahu = {      // Dane dotyczące cech bez względu na osprzęt

        new AHU { ID=1 , Name="Amber 1 K-300", Breadth=360, Height=730, Lenght= 950, Diameter= 160, Weight= 60, ExtPres=280, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50", Efficiency=78.4 , PowClass="B", SoundLevel= 45 },
        new AHU { ID=2 , Name="Amber 1 K-500" , Breadth=500, Height=730, Lenght= 950, Diameter= 200, Weight= 76, ExtPres=265, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50", Efficiency=78 , PowClass="B", SoundLevel= 46 },
        new AHU { ID=3 , Name="Amber 1 K-800" , Breadth=500, Height=1030, Lenght= 1350, Diameter= 250, Weight= 127, ExtPres=270, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=80.4 , PowClass="B", SoundLevel= 47 },
        new AHU { ID=5 , Name="Amber 1 K-1200", Breadth=700, Height=1030, Lenght= 1350, Diameter= 315, Weight= 160, ExtPres=335, FanPow= 680, HePower=4000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=83.5 , PowClass="B", SoundLevel= 49 },

        new AHU { ID=11 , Name="Amber 1 KP-300", Breadth=860, Height=300, Lenght= 1000, Diameter= 160, Weight= 77, ExtPres=250, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50", Efficiency=81 , PowClass="B", SoundLevel= 45 },
        new AHU { ID=12 , Name="Amber 1 KP-500", Breadth=960, Height=300, Lenght= 1100, Diameter= 200, Weight= 86, ExtPres=245, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50", Efficiency=77 , PowClass="B", SoundLevel= 46 },
        new AHU { ID=13 , Name="Amber 1 KP-800" , Breadth=1150, Height=375, Lenght= 1300, Diameter= 250, Weight= 124, ExtPres=250, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=73.5 , PowClass="B", SoundLevel= 47},
        new AHU { ID=15 , Name="Amber 1 KP-1200", Breadth=1260, Height=375, Lenght= 1600, Diameter= 315, Weight= 157, ExtPres=300, FanPow= 680, HePower=4000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=73 , PowClass="B", SoundLevel= 49 },



        new AHU { ID=21 , Name="Amber 1 P-300" , Breadth=500, Height=680, Lenght= 750, Diameter= 160, Weight= 42, ExtPres=275, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50", Efficiency=90 , PowClass="A+", SoundLevel= 45 },
        new AHU { ID=22 , Name="Amber 1 P-500", Breadth=560, Height=680, Lenght= 750, Diameter= 200, Weight= 66, ExtPres=295, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50", Efficiency=91 , PowClass="A+", SoundLevel= 46 },
        new AHU { ID=23 , Name="Amber 1 P-800", Breadth=560, Height=880, Lenght= 900, Diameter= 250, Weight= 98, ExtPres=240, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=90.5 , PowClass="A+", SoundLevel= 47 },
        new AHU { ID=24 , Name="Amber 1 P-1200", Breadth=810, Height=980, Lenght= 1050, Diameter= 315, Weight= 132, ExtPres=305, FanPow= 680, HePower=4000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=90.5 , PowClass="A+", SoundLevel= 49 },


        new AHU { ID=31 , Name="Amber 1 PP-300", Breadth=600, Height=300, Lenght= 1300, Diameter= 160, Weight= 54, ExtPres=265, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50", Efficiency=91.3 , PowClass="A+", SoundLevel= 45 },
        new AHU { ID=32 , Name="Amber 1 PP-500", Breadth=1000, Height=300, Lenght= 1300, Diameter= 200, Weight= 87, ExtPres=280, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50",  Efficiency=91.2 , PowClass="A+", SoundLevel= 46 },
        new AHU { ID=33 , Name="Amber 1 PP-800", Breadth=1000, Height=375, Lenght= 1600, Diameter= 250, Weight= 113, ExtPres=250, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50",  Efficiency=90.7 , PowClass="A+", SoundLevel= 47 },
        new AHU { ID=34 , Name="Amber 1 PP-1200", Breadth=1300, Height=375, Lenght= 1600, Diameter= 315, Weight= 145, ExtPres=300, FanPow= 166, HePower=4000, SupVolHe="3x400/50", SupVol="230/50",  Efficiency=90.4 , PowClass="A+", SoundLevel= 49},


        new AHU { ID=41 , Name="Amber 1 O-300", Breadth=510, Height=630, Lenght= 750, Diameter= 160, Weight= 52, ExtPres=285, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50",  Efficiency=84.3 , PowClass="A", SoundLevel= 45, RotPowCons=40 },
        new AHU { ID=42 , Name="Amber 1 O-500", Breadth=610, Height=730, Lenght= 750, Diameter= 200, Weight= 69, ExtPres=285, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50",  Efficiency=84.2 , PowClass="A", SoundLevel= 46, RotPowCons=40 },
        new AHU { ID=43 , Name="Amber 1 O-800", Breadth=710, Height=780, Lenght= 800, Diameter= 250, Weight= 85, ExtPres=280, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50",  Efficiency=83.2 , PowClass="A", SoundLevel= 47, RotPowCons=40 },
        new AHU { ID=44 , Name="Amber 1 O-1200", Breadth=810, Height=880, Lenght= 850, Diameter= 315, Weight= 110, ExtPres=305, FanPow= 680, HePower=4000, SupVolHe="3x400/50", SupVol="230/50",  Efficiency=81.8 , PowClass="A", SoundLevel= 49, RotPowCons=40 },


        new AHU { ID=51 , Name="Amber 1 OP-300", Breadth=600, Height=400, Lenght= 1250, Diameter= 160, Weight= 56, ExtPres=235, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50", Efficiency=78.5 , PowClass="A", SoundLevel= 45, RotPowCons=40 },
        new AHU { ID=52 , Name="Amber 1 OP-500", Breadth=835, Height=400, Lenght= 1250, Diameter= 200, Weight= 77, ExtPres=250, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50",  Efficiency=81 , PowClass="A", SoundLevel= 46, RotPowCons=40 },
        new AHU { ID=53 , Name="Amber 1 OP-800", Breadth=1180, Height=400, Lenght= 1350, Diameter= 250, Weight= 110, ExtPres=225, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50",  Efficiency=80 , PowClass="A", SoundLevel= 47, RotPowCons=40 },
        new AHU { ID=54 , Name="Amber 1 OP-1200", Breadth=1575, Height=400, Lenght= 1350, Diameter= 315, Weight= 142, ExtPres=270, FanPow= 166, HePower=4000, SupVolHe="3x400/50", SupVol="230/50",  Efficiency=78.5 , PowClass="A", SoundLevel= 49, RotPowCons=40 },


        new AHU { ID=121 , Name="Amber 2 P-300", Breadth=500, Height=680, Lenght= 950, Diameter= 160, Weight= 65, ExtPres=275, FanPow= 166, HePower=1000, SupVolHe="230/50", SupVol="230/50",  Efficiency=90, PowClass="A+", SoundLevel= 45},
        new AHU { ID=122 , Name="Amber 2 P-500", Breadth=560, Height=680, Lenght= 1050, Diameter= 200, Weight= 72, ExtPres=295, FanPow= 230, HePower=2000, SupVolHe="230/50", SupVol="230/50",  Efficiency=91 , PowClass="A+", SoundLevel= 46 },
        new AHU { ID=123 , Name="Amber 2 P-800", Breadth=560, Height=1080, Lenght= 1200, Diameter= 250, Weight= 110, ExtPres=240, FanPow= 340, HePower=3000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=90.5 , PowClass="A+", SoundLevel= 47},
        new AHU { ID=124 , Name="Amber 2 P-1200", Breadth=810, Height=1080, Lenght= 1300, Diameter= 315, Weight= 152, ExtPres=305, FanPow= 680, HePower=4000, SupVolHe="3x400/50", SupVol="230/50", Efficiency=90.5 , PowClass="A+", SoundLevel= 49 },


        new AHU { ID=244 , Name="Amber 1 Wersja Dachowa O-1200", Breadth=1070, Height=970, Lenght= 1730, Diameter= 315, Weight= 168, ExtPres=305, FanPow= 680, WoPower=6260, SupVol="230/50", Efficiency=81.8 , PowClass="A", SoundLevel= 49  },
       


        };


            



        // wykesy A1 K

        public double CA1K300(int i)

        {
            return 1000 * (-1.9314 * Math.Pow(0.001 * i, 3) + 1.8602 * Math.Pow(0.001 * i, 2) - 1.7862 * 0.001 * i + 0.7071);
        }


        public double CA1K500(int i)
        {
            return 1000 * (-4.2069 * Math.Pow(0.001 * i, 3) + 5.7547 * Math.Pow(0.001 * i, 2) - 3.6535 * 0.001 * i + 1.1954);
        }


        public double CA1K800(int i)
        {

          
            return 1000 * (3.3399 * Math.Pow(0.001 * i, 4) - 10.986 * Math.Pow(0.001 * i, 3) + 12.887 * Math.Pow(0.001 * i, 2) - 7.0441 * 0.001 * i + 1.9284);

        }

        public double CA1K1200(int i)
        {
            return 1000 * (-0.0909 * Math.Pow(0.001 * i, 3) + 0.2342 * Math.Pow(0.001 * i, 2) - 0.5916 * 0.001 * i + 0.7698);
        }


       

        // wykesy A1 KP

        public double CA1KP300(int i)

        {
            return 1000 * (-0.3452 * Math.Pow(0.001 * i, 2) - 1.1452 * 0.001 * i + 0.6244);

        }


        public double CA1KP500(int i)
        {
            return 1000 * (-2.7106 * Math.Pow(0.001 * i, 3) + 3.7524 * Math.Pow(0.001 * i, 2) - 2.8432 * 0.001 * i + 1.0681);
        }


        public double CA1KP800(int i)
        {

            return 1000 * (-0.8613 * Math.Pow(0.001 * i, 3) + 1.7783 * Math.Pow(0.001 * i, 2) - 1.9438 * 0.001 * i + 1.1125);


        }

        public double CA1KP1200(int i)
        {
            return 1000 * (0.3224 * Math.Pow(0.001 * i, 3) - 1.4275 * Math.Pow(0.001 * i, 2) + 1.6332 * 0.001 * i - 0.2282);
        }


        // wykesy A1 P

        public double CA1P300(int i)
        {

            return 1000 * (-5.1575 * Math.Pow(0.001 * i, 3) + 5.2417 * Math.Pow(0.001 * i, 2) - 2.8509 * 0.001 * i + 0.8068);
        }

        public double CA1P500(int i)
        {
            return 1000 * (-13.38 * Math.Pow(0.001 * i, 4) + 32.431 * Math.Pow(0.001 * i, 3) - 28.047 * Math.Pow(0.001 * i, 2) + 9.2137 * 0.001 * i - 0.5203);
        }




        public double CA1P800(int i)
        {
            return 1000 * (-0.7303 * Math.Pow(0.001 * i, 3) + 1.1888 * Math.Pow(0.001 * i, 2) - 1.2193 * 0.001 * i + 0.8381);
        }


        public double CA1P1200(int i)
        {
            return 1000 * (1.4605 * Math.Pow(0.001 * i, 4) - 7.5065 * Math.Pow(0.001 * i, 3) + 13.786 * Math.Pow(0.001 * i, 2) - 11.166 * 0.001 * i + 3.7994);
        }


        // wykesy A1 PP

        public double CA1PP300(int i)
        {
            return 1000 * (-3.4876 * Math.Pow(0.001 * i, 3) + 3.372 * Math.Pow(0.001 * i, 2) - 2.2467 * 0.001 * i + 0.7324);

        }


        public double CA1PP500(int i)
        {
            return 1000 * (-2.0822 * Math.Pow(0.001 * i, 3) + 2.9417 * Math.Pow(0.001 * i, 2) - 2.4398 * 0.001 * i + 1.0298);
        }

        public double CA1PP800(int i)
        {
            return 1000 * (2.6681 * Math.Pow(0.001 * i, 4) - 8.4583 * Math.Pow(0.001 * i, 3) + 9.588 * Math.Pow(0.001 * i, 2) - 5.3279 * 0.001 * i + 1.6119);
        }


        public double CA1PP1200(int i)
        {
            return 1000 * (0.5369 * Math.Pow(0.001 * i, 3) - 2.513 * Math.Pow(0.001 * i, 2) + 3.2425 * 0.001 * i - 0.8961);

        }
 

        // wykesy A1 O

        public double CA1O300(int i)
        {
            return 1000 * (-4.3816 * Math.Pow(0.001 * i, 3) + 4.9977 * Math.Pow(0.001 * i, 2) - 2.7967 * 0.001 * i + 0.7945);
        }

        public double CA1O500(int i)
        {
            return 1000 * (-3.2559 * Math.Pow(0.001 * i, 3) + 4.3054 * Math.Pow(0.001 * i, 2) - 2.8447 * 0.001 * i + 1.0457);
        }


        public double CA1O800(int i)
        {
            return 1000 * (4.1079 * Math.Pow(0.001 * i, 4) - 13.678 * Math.Pow(0.001 * i, 3) + 16.063 * Math.Pow(0.001 * i, 2) - 8.5283 * 0.001 * i + 2.1345);
        }

        public double CA1O1200(int i)
        {

            return 1000 * (0.8833 * Math.Pow(0.001 * i, 4) - 4.9036 * Math.Pow(0.001 * i, 3) + 9.5619 * Math.Pow(0.001 * i, 2) - 8.3147 * 0.001 * i + 3.1681);
        }


        // wykesy A1 OP
        public double CA1OP300(int i)
        {
            return 1000 * (-2.0802 * Math.Pow(0.001 * i, 3) + 2.2249 * Math.Pow(0.001 * i, 2) - 1.9346 * 0.001 * i + 0.679);
        }

        public double CA1OP500(int i)
        {
            return 1000 * (-0.5081 * Math.Pow(0.001 * i, 2) - 0.6226 * 0.001 * i + 0.6992);
        }


        public double CA1OP800(int i)
        {
            return 1000 * (-1.1701 * Math.Pow(0.001 * i, 3) + 2.2308 * Math.Pow(0.001 * i, 2) - 2.0069 * 0.001 * i + 1.0116);
        }


        public double CA1OP1200(int i)
        {
            return 1000 * (0.25 * Math.Pow(0.001 * i, 3) - 1.0786 * Math.Pow(0.001 * i, 2) + 0.9804 * 0.001 * i + 0.2184);
        }


        // wykesy A2 P

        public double CA2P300(int i)
        {
            return 1000 * (-4.4627 * Math.Pow(0.001 * i, 3) + 4.5843 * Math.Pow(0.001 * i, 2) - 2.6578 * 0.001 * i + 0.7903);
        }


        public double CA2P500(int i)
        {
            return 1000 * (1.3998 * Math.Pow(0.001 * i, 3) - 1.7805 * Math.Pow(0.001 * i, 2) - 0.3709 * 0.001 * i + 0.748);
        }


        public double CA2P800(int i)
        {
            return 1000 * (-0.5654 * Math.Pow(0.001 * i, 3) + 0.7544 * Math.Pow(0.001 * i, 2) - 0.8446 * 0.001 * i + 0.7341);
        }



        public double CA2P1200(int i)
        {
            return 1000 * (0.3679 * Math.Pow(0.001 * i, 3) - 1.9509 * Math.Pow(0.001 * i, 2) + 2.6396 * 0.001 * i - 0.6843);
        }

        // wykesy A1  Wersja DACHOWA


        public double CADOP1200(int i)
        {
            return 1000 * (0.8833 * Math.Pow(0.001 * i, 4) - 4.9036 * Math.Pow(0.001 * i, 3) + 9.5619 * Math.Pow(0.001 * i, 2) - 8.3147 * 0.001 * i + 3.1681);

        }

    }

    public enum TypList

    {
        [Display(Name ="Amber 1")]
        Amber_1 = 0,

        [Display(Name="Amber 2")]
        Amber_2 = 100,

        [Display(Name="Amber1 wersja dachowa")]
        Amber_1_Dach = 200,
        

    }




    


}