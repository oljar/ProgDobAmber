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




        // wykesy

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