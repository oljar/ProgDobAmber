using System;
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

        [Required(ErrorMessage = "Proszę podać wartość liczbową w [m3/h] ")]
        public int Sprez { get; set; }

        public int Centrala { get; set; }


        public TypList Typoszereg { get; set; }

        public int Wymiennik { get; set; }


        [Required(ErrorMessage = "Proszę podać wartość liczbową w [m3/h] ")]
        public int WydNom { get; set; }

        public int Montaz { get; set; }

        public double X = 0.9;  // współczynnik bezpieczeństwa

        public int MaxSprez = 440;




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