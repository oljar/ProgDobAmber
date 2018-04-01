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